#include <AccelStepper.h>
#include <Servo.h>

// --- ĐỊNH NGHĨA CHÂN ĐỘNG CƠ BƯỚC ---
#define PUL_1         3   // Trục 1 (TB6600)
#define DIR_1         12  
#define ENA_1         11

#define PUL_2         43   // Trục 2 (A4988)
#define DIR_2         41  
#define ENA_2         10

// --- ĐỊNH NGHĨA CÔNG TẮC HÀNH TRÌNH ---
#define LIMIT_1_MIN   22  // Vị trí Gốc Trục 1
#define LIMIT_1_MAX   24  
#define LIMIT_2_MIN   26  // Vị trí Gốc Trục 2
#define LIMIT_2_MAX   28  // Vị trí Giới hạn trên Trục 2

// --- ĐỊNH NGHĨA NÚT NHẤN ---
#define BUTTON_START_1 34  // Nút chạy chu trình 1
#define BUTTON_START_2 36  // Nút chạy chu trình 2
#define BUTTON_STOP    30  
#define BUTTON_HOME    32
#define BUTTON_TOGGLE_MODE 38 // Nút chuyển đổi xoay vòng chế độ

// --- ĐỊNH NGHĨA CHÂN JOYSTICK & BIẾN TRỞ ---
#define JOY_X_PIN      A4  // Trục X - Điều khiển Trục 1
#define JOY_Y_PIN      A5  // Trục Y - Điều khiển Trục 2
#define JOY_SW_PIN     13  // Nút nhấn Joystick (optional)

#define POT1_PIN       A0  // Biến trở 1 - Điều khiển Servo 1
#define POT2_PIN       A1  // Biến trở 2 - Điều khiển Servo 2
#define POT3_PIN       A2  // Biến trở 3 - Điều khiển Servo 3
#define POT4_PIN       A3  // Biến trở 4 - Điều khiển Servo 4

// --- ĐỊNH NGHĨA CHÂN ĐÈN LED BÁO TRẠNG THÁI ---
#define LED_READY_PIN    4  // Sáng khi INIT, HOMING, READY (AUTO)
#define LED_RUNNING_PIN  6  // Sáng khi chạy CYCLE_1 hoặc CYCLE_2
#define LED_MANUAL_PIN   7  // Sáng khi ở MANUAL_MODE (Phần cứng)
#define LED_STOP_PIN     5  // Sáng khi ở EMERGENCY_STOP
#define LED_GUI_PIN      8  // MỚI: Sáng khi ở MANUAL_GUI_MODE (Giao diện)

// --- KHỞI TẠO ĐỐI TƯỢNG ---
AccelStepper stepper1(AccelStepper::DRIVER, PUL_1, DIR_1);
AccelStepper stepper2(AccelStepper::DRIVER, PUL_2, DIR_2);

Servo servo1, servo2, servo3, servo4; 

// Thêm trạng thái MANUAL_GUI_MODE vào máy trạng thái
enum RobotState { INIT, HOMING, READY, RUNNING_CYCLE_1, RUNNING_CYCLE_2, EMERGENCY_STOP, MANUAL_MODE, MANUAL_GUI_MODE };
RobotState currentState = INIT; 

const int SPEED_HOME = 600;      
const int SPEED_RUN = 1000;       
const int BACKOFF_STEPS_1 = 800; 
const int BACKOFF_STEPS_2 = 4000;  

// Các biến hỗ trợ chế độ bằng tay (MANUAL)
const int JOY_DEADZONE = 50;  
const int POT_THRESHOLD = 5;  
int lastPotValues[4] = {0, 0, 0, 0}; 

// Biến lưu trữ giá trị điều khiển từ GUI
int guiJoystickX = 0;
int guiJoystickY = 0;
int guiServoAngles[4] = {90, 90, 90, 90}; // Giá trị mặc định

void setup() {
  Serial.begin(115200);

  // Cấu hình nút bấm
  pinMode(BUTTON_START_1, INPUT_PULLUP);
  pinMode(BUTTON_START_2, INPUT_PULLUP);
  pinMode(BUTTON_STOP, INPUT_PULLUP);
  pinMode(BUTTON_HOME, INPUT_PULLUP);
  pinMode(BUTTON_TOGGLE_MODE, INPUT_PULLUP);
  
  // Cấu hình công tắc hành trình
  pinMode(LIMIT_1_MIN, INPUT_PULLUP);
  pinMode(LIMIT_1_MAX, INPUT_PULLUP);
  pinMode(LIMIT_2_MIN, INPUT_PULLUP);
  pinMode(LIMIT_2_MAX, INPUT_PULLUP);

  // Cấu hình ngõ ra cho các chân Đèn LED (bao gồm cả D50)
  pinMode(LED_READY_PIN, OUTPUT);
  pinMode(LED_RUNNING_PIN, OUTPUT);
  pinMode(LED_MANUAL_PIN, OUTPUT);
  pinMode(LED_STOP_PIN, OUTPUT);
  pinMode(LED_GUI_PIN, OUTPUT);

  // Cấp điện mặc định cho động cơ bước (LOW là Enable)
  digitalWrite(ENA_1, LOW);   digitalWrite(ENA_2, LOW); 

  // Attach Servo
  servo1.attach(51); servo2.attach(49); servo3.attach(47); servo4.attach(45); 

  // Cấu hình tốc độ/gia tốc mặc định
  stepper1.setMaxSpeed(1500);  
  stepper1.setAcceleration(1000);
  stepper2.setMaxSpeed(1500);
  stepper2.setAcceleration(1000);

  Serial.println("--- SYSTEM_READY: Robot Khởi Động (INIT) ---");
  Serial.println("STATE_CHANGED: INIT"); // Explicitly send initial state
}

void loop() {
  // 1. ƯU TIÊN CAO NHẤT: Kiểm tra dừng khẩn cấp (Phần cứng & Phần mềm)
  if (digitalRead(BUTTON_STOP) == LOW) {
    checkEmergency();
  }
  checkSerialCommand(); // Quét nhận dữ liệu liên tục từ WinForms gửi xuống

  // 2. KIỂM TRA NÚT BẤM CHUYỂN CHẾ ĐỘ VẬT LÝ D38 (Chỉ cho phép khi hệ thống rảnh rỗi)
  if (currentState == INIT || currentState == READY || currentState == MANUAL_MODE || currentState == MANUAL_GUI_MODE) {
    if (digitalRead(BUTTON_TOGGLE_MODE) == LOW) {
      delay(50); // Chống rung phím
      if (digitalRead(BUTTON_TOGGLE_MODE) == LOW) {
        
        // Gọi hàm xử lý chuyển đổi vòng tròn dùng chung
        toggleControlMode();
        
        // Vòng lặp chờ nhả nút nhấn để tránh bị nhảy liên tục
        while(digitalRead(BUTTON_TOGGLE_MODE) == LOW) {
          if (digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
        }
      }
    }
  }

  // 3. QUẢN LÝ LUỒNG HOẠT ĐỘNG CHÍNH VÀ ĐIỀU KHIỂN
  switch (currentState) {
    case INIT:
    case EMERGENCY_STOP: 
      if (digitalRead(BUTTON_HOME) == LOW) {
        delay(50); 
        if (digitalRead(BUTTON_HOME) == LOW) {
          startHomingSequence();
        }
      }
      break;

    case READY:
      if (digitalRead(BUTTON_START_1) == LOW) {
        delay(50); 
        if (digitalRead(BUTTON_START_1) == LOW) {
          currentState = RUNNING_CYCLE_1;
          executeCycle1();
        }
      }
      else if (digitalRead(BUTTON_START_2) == LOW) {
        delay(50); 
        if (digitalRead(BUTTON_START_2) == LOW) {
          currentState = RUNNING_CYCLE_2;
          executeCycle2();
        }
      }
      break;

    case MANUAL_MODE:
      executeManualControl(); // Đọc Joystick và Biến trở vật lý
      break;

    case MANUAL_GUI_MODE:
      executeManualGuiControl(); // Chế độ giao diện máy tính nắm quyền (khóa phần cứng)
      break;

    case RUNNING_CYCLE_1:
    case RUNNING_CYCLE_2:
    case HOMING:
      break;
  }

  // Cập nhật trạng thái hiển thị của các đèn chỉ báo
  updateStatusLEDs();
}

// ====================================================================
// --- HÀM ĐỒNG BỘ CHUYỂN CHẾ ĐỘ XOAY VÒNG (DÙNG CHUNG CHO CƠ & GUI) ---
// ====================================================================
void toggleControlMode() {
  if (currentState == READY || currentState == INIT) {
    // Từ Tự động -> Chuyển sang Manual Phần cứng
    currentState = MANUAL_MODE;
    digitalWrite(ENA_1, LOW); digitalWrite(ENA_2, LOW);
    
    // Cập nhật giá trị biến trở hiện tại để tránh giật Servo khi vừa chuyển chế độ
    lastPotValues[0] = analogRead(POT1_PIN); lastPotValues[1] = analogRead(POT2_PIN);
    lastPotValues[2] = analogRead(POT3_PIN); lastPotValues[3] = analogRead(POT4_PIN);
    
    Serial.println("STATE_CHANGED: MANUAL_HARDWARE");
  } 
  else if (currentState == MANUAL_MODE) {
    // Từ Manual Phần cứng -> Chuyển sang Manual Giao diện (MỚI)
    currentState = MANUAL_GUI_MODE;
    digitalWrite(ENA_1, LOW); digitalWrite(ENA_2, LOW);
    
    Serial.println("STATE_CHANGED: MANUAL_GUI");
  } 
  else if (currentState == MANUAL_GUI_MODE) {
    // Từ Manual Giao diện -> Quay vòng lại chế độ Tự động (READY)
    currentState = READY;
    Serial.println("STATE_CHANGED: AUTOMATIC");
  }
  updateStatusLEDs();
}

// ====================================================================
// --- HÀM ĐỌC VÀ XỬ LÝ LỆNH TỪ WINFORMS GỬI XUỐNG ---
// ====================================================================
void checkSerialCommand() {
  if (Serial.available()) {
    String command = Serial.readStringUntil('\n'); // Đọc toàn bộ chuỗi cho đến khi gặp ký tự xuống dòng
    command.trim(); // Loại bỏ khoảng trắng thừa

    if (command.length() == 0) return; // Không có lệnh nào

    // 1. Lệnh dừng khẩn cấp từ giao diện WinForms
    if (command == "E") {
      checkEmergency();
      return;
    }
    
    // 2. Lệnh chuyển chế độ đồng bộ
    if (command == "M") {
      if (currentState == INIT || currentState == READY || currentState == MANUAL_MODE || currentState == MANUAL_GUI_MODE) {
        toggleControlMode();
      }
      return;
    }
    
    // 3. Lệnh kích hoạt HOME
    if (command == "H" && (currentState == INIT || currentState == EMERGENCY_STOP)) {
      startHomingSequence();
      return;
    }
    
    // 4. Lệnh kích hoạt chu trình 1 & 2
    if (currentState == READY) {
      if (command == "1") { currentState = RUNNING_CYCLE_1; executeCycle1(); }
      else if (command == "2") { currentState = RUNNING_CYCLE_2; executeCycle2(); }
    }

    // 5. Lệnh điều khiển Joystick từ GUI (chỉ khi ở MANUAL_GUI_MODE)
    if (currentState == MANUAL_GUI_MODE && command.startsWith("J:")) {
      // Định dạng: J:X,Y
      int firstComma = command.indexOf(',');
      if (firstComma != -1) {
        guiJoystickX = command.substring(2, firstComma).toInt();
        guiJoystickY = command.substring(firstComma + 1).toInt();
      }
      return;
    }

    // 6. Lệnh điều khiển Servo từ GUI (chỉ khi ở MANUAL_GUI_MODE)
    if (currentState == MANUAL_GUI_MODE && command.startsWith("S:")) {
      // Định dạng: S:ID,ANGLE
      int firstComma = command.indexOf(',');
      if (firstComma != -1) {
        int servoID = command.substring(2, firstComma).toInt();
        int angle = command.substring(firstComma + 1).toInt();
        
        if (servoID >= 1 && servoID <= 4) {
          guiServoAngles[servoID - 1] = angle;
          // Điều khiển servo ngay lập tức
          switch (servoID) {
            case 1: servo1.write(angle); break;
            case 2: servo2.write(angle); break;
            case 3: servo3.write(angle); break;
            case 4: servo4.write(angle); break;
          }
          // Gửi phản hồi về GUI
          Serial.print("FB_S:");
          Serial.print(servoID);
          Serial.print(",");
          Serial.println(angle);
        }
      }
      return;
    }
  }
}

// Hàm gửi phản hồi vị trí Stepper
void sendStepperFeedback() {
  Serial.print("FB_STEP:");
  Serial.print(stepper1.currentPosition());
  Serial.print(",");
  Serial.println(stepper2.currentPosition());
}

void startHomingSequence() {
  digitalWrite(ENA_1, LOW); 
  digitalWrite(ENA_2, LOW);
  delay(50); 
  currentState = HOMING;
  executeHoming();
  // Sau khi homing, gửi vị trí hiện tại về GUI
  sendStepperFeedback();
}

// ====================================================================
// --- HÀM CẬP NHẬT TRẠNG THÁI 5 ĐÈN LED CHỈ BÁO ---
// ====================================================================
void updateStatusLEDs() {
  switch (currentState) {
    case INIT:
    case HOMING:
    case READY:
      digitalWrite(LED_READY_PIN, HIGH);
      digitalWrite(LED_RUNNING_PIN, LOW);
      digitalWrite(LED_MANUAL_PIN,  LOW);
      digitalWrite(LED_STOP_PIN,    LOW);
      digitalWrite(LED_GUI_PIN,     LOW); // Tắt LED GUI
      break;

    case RUNNING_CYCLE_1:
    case RUNNING_CYCLE_2:
      digitalWrite(LED_READY_PIN,   LOW);
      digitalWrite(LED_RUNNING_PIN, HIGH);
      digitalWrite(LED_MANUAL_PIN,  LOW);
      digitalWrite(LED_STOP_PIN,    LOW);
      digitalWrite(LED_GUI_PIN,     LOW);
      break;

    case MANUAL_MODE:
      digitalWrite(LED_READY_PIN,   LOW);
      digitalWrite(LED_RUNNING_PIN, LOW);
      digitalWrite(LED_MANUAL_PIN,  HIGH); // Bật LED D46 (Manual phần cứng)
      digitalWrite(LED_STOP_PIN,    LOW);
      digitalWrite(LED_GUI_PIN,     LOW);
      break;

    case MANUAL_GUI_MODE:
      digitalWrite(LED_READY_PIN,   LOW);
      digitalWrite(LED_RUNNING_PIN, LOW);
      digitalWrite(LED_MANUAL_PIN,  LOW);
      digitalWrite(LED_STOP_PIN,    LOW);
      digitalWrite(LED_GUI_PIN,     HIGH); // Bật LED D50 (Manual giao diện)
      break;

    case EMERGENCY_STOP:
      digitalWrite(LED_READY_PIN,   LOW);
      digitalWrite(LED_RUNNING_PIN, LOW);
      digitalWrite(LED_MANUAL_PIN,  LOW);
      digitalWrite(LED_STOP_PIN,    HIGH);
      digitalWrite(LED_GUI_PIN,     LOW);
      break;
  }
}

// --- HÀM ĐIỀU KHIỂN MANUAL BẰNG PHẦN CỨNG (JOYSTICK & BIẾN TRỞ) ---
void executeManualControl() {
  int potPins[4] = {POT1_PIN, POT2_PIN, POT3_PIN, POT4_PIN};
  Servo* servos[4] = {&servo1, &servo2, &servo3, &servo4};
  
  for (int i = 0; i < 4; i++) {
    int currentPot = analogRead(potPins[i]);
    if (abs(currentPot - lastPotValues[i]) > POT_THRESHOLD) {
      int targetAngle = map(currentPot, 0, 1023, 0, 180);
      servos[i]->write(targetAngle); 
      lastPotValues[i] = currentPot; 
    }
  }

  int joyX = analogRead(JOY_X_PIN);
  processStepperControl(stepper1, joyX, LIMIT_1_MIN, LIMIT_1_MAX);
  
  // Gửi phản hồi vị trí Stepper
  sendStepperFeedback();

  int joyY = analogRead(JOY_Y_PIN);
  processStepperControl(stepper2, joyY, LIMIT_2_MIN, LIMIT_2_MAX);

  // Gửi phản hồi vị trí Stepper
  sendStepperFeedback();
}

// --- MỚI: HÀM ĐIỀU KHIỂN MANUAL TỪ GIAO DIỆN (HÀM ĐỂ TRỐNG ĐỂ XỬ LÝ CHUỖI GỬI VỀ) ---
void executeManualGuiControl() {
  // Điều khiển Stepper bằng giá trị từ GUI Joystick
  processStepperControl(stepper1, map(guiJoystickX, -100, 100, 0, 1023), LIMIT_1_MIN, LIMIT_1_MAX);
  processStepperControl(stepper2, map(guiJoystickY, -100, 100, 0, 1023), LIMIT_2_MIN, LIMIT_2_MAX);

  // Gửi phản hồi vị trí Stepper
  sendStepperFeedback();
  // Servo đã được điều khiển trực tiếp trong checkSerialCommand()
}

void processStepperControl(AccelStepper &stepper, int joyValue, int limitMinPin, int limitMaxPin) {
  if (joyValue > (512 + JOY_DEADZONE)) {
    if (digitalRead(limitMaxPin) == LOW) {
      int speed = map(joyValue, 512 + JOY_DEADZONE, 1023, 0, SPEED_RUN);
      stepper.setSpeed(-speed); 
      stepper.runSpeed();
    } else {
      stepper.stop();
    }
  }
  else if (joyValue < (512 - JOY_DEADZONE)) {
    if (digitalRead(limitMinPin) == LOW) {
      int speed = map(joyValue, 512 - JOY_DEADZONE, 0, 0, SPEED_RUN);
      stepper.setSpeed(speed);
      stepper.runSpeed();
    } else {
      stepper.stop();
    }
  }
  else {
    stepper.stop();
  }
}

void checkEmergency() {
  if (currentState != EMERGENCY_STOP) {
    Serial.println("STATE_CHANGED: EMERGENCY_STOP");
    stepper1.stop();
    stepper2.stop();
    digitalWrite(ENA_1, HIGH); 
    digitalWrite(ENA_2, HIGH);
    currentState = EMERGENCY_STOP;
    updateStatusLEDs(); 
  }
}

bool safeDelay(unsigned long ms) {
  unsigned long start = millis();
  while (millis() - start < ms) {
    if (digitalRead(BUTTON_STOP) == LOW) {
      checkEmergency(); // Gọi hàm dừng khẩn cấp
      return false; 
    }
    // Quét thêm cả dữ liệu cổng âm từ WinForms đề phòng người dùng nhấn STOP mềm trên máy tính
    if (Serial.available() > 0) {
      if (Serial.read() == 'E') { checkEmergency(); return false; }
    }
    updateStatusLEDs(); 
  }
  return true;
}

bool moveServosSimultaneously(Servo &sA, int targetA, Servo &sB, int targetB, unsigned long durationMs) {
  int startA = sA.read();
  int startB = sB.read();
  unsigned long startTime = millis();
  
  while (millis() - startTime < durationMs) {
    if (digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return false; }
    if (Serial.available() > 0) { if (Serial.read() == 'E') { checkEmergency(); return false; } }
    
    float progress = (float)(millis() - startTime) / durationMs;
    int currentA = startA + (targetA - startA) * progress;
    int currentB = startB + (targetB - startB) * progress;
    
    sA.write(currentA);
    sB.write(currentB);
    updateStatusLEDs(); 
    delay(15); 
  }
  sA.write(targetA);
  sB.write(targetB);
  return true;
}

void executeCycle1() {
  Serial.println("STATE_CHANGED: RUNNING");
  updateStatusLEDs(); 
  
  servo4.write(15); if(!safeDelay(800)) return;
  servo2.write(30); if(!safeDelay(800)) return;
  servo1.write(100); if(!safeDelay(800)) return;
  // Gửi phản hồi Servo
  Serial.println("FB_S:4,15"); Serial.println("FB_S:2,30"); Serial.println("FB_S:1,100");


  
  // 2. Di chuyển đến giới hạn tối đa
  while (digitalRead(LIMIT_2_MAX) == LOW) { 
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper2.setSpeed(-SPEED_RUN); 
    stepper2.runSpeed();
    updateStatusLEDs();
  }
  stepper2.stop(); if(!safeDelay(500)) return;
  sendStepperFeedback(); // Gửi phản hồi Stepper

  // 3. Thao tác tại vị trí Max
  servo4.write(90); if(!safeDelay(800)) return;
  servo1.write(85); if(!safeDelay(800)) return;
  servo2.write(130); if(!safeDelay(800)) return;
  // Gửi phản hồi Servo
  Serial.println("FB_S:4,90"); Serial.println("FB_S:1,85"); Serial.println("FB_S:2,130");

  // Đoạn code cũ, cần xem xét lại logic này
  // Cho servo1 và servo3 quay đồng thời (Đoạn chèn ở yêu cầu trước)
  servo2.write(130);
  servo3.write(150);
  
  for (int angle1 = 85; angle1 >= 0; angle1--) {
  servo1.write(angle1);
  
  // Vẫn sử dụng safeDelay nhỏ để giữ tính năng an toàn (Nút STOP)
  if (!safeDelay(15)) return; 
}
  Serial.println("FB_S:1,0"); // Giả định servo1 về 0
  if(!safeDelay(800)) return; 

  // 4. Di chuyển ngược lại về giới hạn tối thiểu
  while (digitalRead(LIMIT_2_MIN) == LOW) { 
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper2.setSpeed(SPEED_RUN); 
    stepper2.runSpeed();
    updateStatusLEDs();
  }
  stepper2.stop(); if(!safeDelay(500)) return;
  sendStepperFeedback(); // Gửi phản hồi Stepper

  // 5. Thao tác tại vị trí Min & Thực hiện lùi an toàn (Backoff)
  servo4.write(15); if(!safeDelay(800)) return;
  Serial.println("FB_S:4,15"); // Gửi phản hồi Servo

  // ==================== ĐOẠN MỚI CHÈN VÀO ĐÂY ====================
  // Quay đồng thời servo1 về 85 độ và servo3 về 150 độ câu hỏi mới
  servo1.write(85);
  servo3.write(50);
  servo2.write(130);
  Serial.println("FB_S:1,85"); Serial.println("FB_S:3,50"); Serial.println("FB_S:2,130"); // Gửi phản hồi Servo
  if(!safeDelay(800)) return; // Đợi cả 2 servo quay xong
  // ===============================================================


  servo4.write(90); if(!safeDelay(800)) return;

  // Bắt đầu quá trình lùi an toàn (Backoff)
  stepper2.setCurrentPosition(0);
  stepper2.moveTo(-BACKOFF_STEPS_2); 
  while (stepper2.distanceToGo() != 0) {
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper2.run();
    updateStatusLEDs();
  }
  sendStepperFeedback(); // Gửi phản hồi Stepper
  stepper2.setCurrentPosition(0); if(!safeDelay(500)) return;

  // 6. Kết thúc chu trình
  currentState = READY;
  Serial.println("STATE_CHANGED: AUTOMATIC");
}

void executeCycle2() {
  Serial.println("STATE_CHANGED: RUNNING");
  updateStatusLEDs(); 
  
  // Bước 1: servo4 quay góc 15
  servo4.write(15); if(!safeDelay(800)) return;
  Serial.println("FB_S:4,15"); // Gửi phản hồi Servo

  // Bước 2: servo2 quay góc 30
  servo2.write(30); if(!safeDelay(800)) return;
  servo1.write(100); if(!safeDelay(800)) return;
  Serial.println("FB_S:2,30"); Serial.println("FB_S:1,100"); // Gửi phản hồi Servo

  // Bước 3: stepper2 quay đến chạm ctht LIMIT_2_MAX
  while (digitalRead(LIMIT_2_MAX) == LOW) {
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper2.setSpeed(-SPEED_RUN); 
    stepper2.runSpeed();
    updateStatusLEDs();
  }
  stepper2.stop(); if(!safeDelay(500)) return;
  sendStepperFeedback(); // Gửi phản hồi Stepper

  // Bước 4: servo4 quay góc 90
  servo4.write(90); if(!safeDelay(800)) return;
  servo1.write(85); if(!safeDelay(800)) return;
  Serial.println("FB_S:4,90"); Serial.println("FB_S:1,85"); // Gửi phản hồi Servo


  // Bước 5: stepper1 quay đến chạm ctht LIMIT_1_MAX
  while (digitalRead(LIMIT_1_MAX) == LOW) {
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper1.setSpeed(-SPEED_RUN); 
    stepper1.runSpeed();
    updateStatusLEDs();
  }
  stepper1.stop(); if(!safeDelay(500)) return;
  sendStepperFeedback(); // Gửi phản hồi Stepper

  // Bước 6: servo4 quay góc 15
  servo4.write(15); if(!safeDelay(800)) return;
  Serial.println("FB_S:4,15"); // Gửi phản hồi Servo

  // Bước 7: servo2 quay góc 130
  servo2.write(130); if(!safeDelay(800)) return;
  Serial.println("FB_S:2,130"); // Gửi phản hồi Servo

  // Bước 8: servo4 quay góc 90
  servo4.write(90); if(!safeDelay(800)) return;
  Serial.println("FB_S:4,90"); // Gửi phản hồi Servo

  if(!safeDelay(500)) return;
  // Bước 9: ĐỒNG THỜI cho stepper1 và stepper2 quay về HOME (Vị trí MIN)
  // Khai báo 2 biến cờ để giám sát trạng thái chạm đích của từng trục độc lập
  bool stepper1_Done = false;
  bool stepper2_Done = false;

  while (!stepper1_Done || !stepper2_Done) {
    // Luôn ưu tiên kiểm tra nút dừng khẩn cấp trong vòng lặp đồng thời
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    if(Serial.available() > 0) { if (Serial.read() == 'E') { checkEmergency(); return; } }

    // --- Xử lý trục 1 ---
    if (!stepper1_Done) {
      if (digitalRead(LIMIT_1_MIN) == LOW) {
        stepper1.setSpeed(SPEED_RUN); // Hướng dương chạy về MIN
        stepper1.runSpeed();
      } else {
        // Đã chạm công tắc hành trình MIN 1 -> Dừng lại và thực hiện lùi an toàn (Backoff 1)
        stepper1.stop();
        stepper1.setCurrentPosition(0);
        stepper1.moveTo(-BACKOFF_STEPS_1); 
        while (stepper1.distanceToGo() != 0) {
          if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
          stepper1.run();
          updateStatusLEDs();
        }
        sendStepperFeedback(); // Gửi phản hồi Stepper
        stepper1.setCurrentPosition(0);
        stepper1_Done = true; // Đánh dấu trục 1 đã về HOME xong
      }
    }

    // --- Xử lý trục 2 ---
    if (!stepper2_Done) {
      if (digitalRead(LIMIT_2_MIN) == LOW) {
        stepper2.setSpeed(SPEED_RUN); // Hướng dương chạy về MIN
        stepper2.runSpeed();
      } else {
        // Đã chạm công tắc hành trình MIN 2 -> Dừng lại và thực hiện lùi an toàn (Backoff 2)
        stepper2.stop();
        stepper2.setCurrentPosition(0);
        stepper2.moveTo(-BACKOFF_STEPS_2); 
        while (stepper2.distanceToGo() != 0) {
          if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
          stepper2.run();
          updateStatusLEDs();
        }
        sendStepperFeedback(); // Gửi phản hồi Stepper
        stepper2.setCurrentPosition(0);
        stepper2_Done = true; // Đánh dấu trục 2 đã về HOME xong
      }
    }

    updateStatusLEDs();
  }

  // Kết thúc chu trình an toàn
  currentState = READY;
  Serial.println("STATE_CHANGED: AUTOMATIC");
}

void executeHoming() {
  Serial.println("STATE_CHANGED: HOMING");
  updateStatusLEDs(); 
  
  servo4.write(90); if(!safeDelay(800)) return;
  servo3.write(50); if(!safeDelay(800)) return;
  servo1.write(85); if(!safeDelay(800)) return; // Đảm bảo servo1 về vị trí an toàn
  servo2.write(130); if(!safeDelay(800)) return;
  // Gửi phản hồi Servo
  Serial.println("FB_S:4,90"); Serial.println("FB_S:3,50");
  Serial.println("FB_S:1,85"); Serial.println("FB_S:2,130");
  
  // --- Homing Động cơ 2 ---
  while (digitalRead(LIMIT_2_MIN) == LOW) { 
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper2.setSpeed(SPEED_HOME); 
    stepper2.runSpeed();
    updateStatusLEDs();
  }
  stepper2.stop(); if(!safeDelay(500)) return;
  sendStepperFeedback(); // Gửi phản hồi Stepper

  stepper2.setCurrentPosition(0);
  // SỬA Ở ĐÂY: Dùng hằng số riêng cho động cơ 2
  stepper2.moveTo(-BACKOFF_STEPS_2); 
  while (stepper2.distanceToGo() != 0) {
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper2.run();
    updateStatusLEDs();
  }
  sendStepperFeedback(); // Gửi phản hồi Stepper
  stepper2.setCurrentPosition(0); 

  // --- Homing Động cơ 1 ---
  while (digitalRead(LIMIT_1_MIN) == LOW) { 
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper1.setSpeed(SPEED_HOME); 
    stepper1.runSpeed();
    updateStatusLEDs();
  }
  stepper1.stop(); if(!safeDelay(500)) return;
  sendStepperFeedback(); // Gửi phản hồi Stepper

  stepper1.setCurrentPosition(0);
  // SỬA Ở ĐÂY: Dùng hằng số riêng cho động cơ 1
  stepper1.moveTo(-BACKOFF_STEPS_1); 
  while (stepper1.distanceToGo() != 0) {
    if(digitalRead(BUTTON_STOP) == LOW) { checkEmergency(); return; }
    stepper1.run();
    updateStatusLEDs();
  }
  sendStepperFeedback(); // Gửi phản hồi Stepper
  stepper1.setCurrentPosition(0); 

  currentState = READY; 
  Serial.println("STATE_CHANGED: AUTOMATIC");
}