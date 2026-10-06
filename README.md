# Robot - Stepper Motor Robotic Arm Control System

A complete robotic arm control solution consisting of a Windows Forms desktop application and an Arduino Mega firmware. The system controls a stepper-motor robotic arm with servo end-effectors over a serial COM port, supporting both automated cycles and manual control modes (physical joystick/potentiometers or GUI virtual joystick).

---

## Features

- **Dual-mode Control**:
  - **Automatic Cycles**: Pre-programmed operational cycles (Cycle 1 & Cycle 2) with limit-switch homing and backoff sequences.
  - **Manual Hardware Mode**: Direct control via physical analog joystick (X/Y stepper axes) and potentiometers (servo motors).
  - **Manual GUI Mode**: Real-time control directly from the WinForms desktop interface using a custom on-screen virtual joystick and trackbars.
- **Safety Interlocks**:
  - Hardware & software Emergency Stop (`E` command and physical STOP button).
  - Min/Max limit switches (`LIMIT_1_MIN`, `LIMIT_1_MAX`, `LIMIT_2_MIN`, `LIMIT_2_MAX`) with automatic safety stop and backoff.
- **Real-time Feedback**:
  - Live stepper motor step positions (`FB_STEP:X,Y`).
  - Real-time servo angle positions (`FB_S:ID,ANGLE`).
  - Machine state transitions reflected across 5 on-screen and hardware indicator LEDs.
  - Action log tracking operations with timestamps.

---

## Project Structure

```text
Robot/
├── App.config               # Application runtime configuration (.NET Framework 4.7.2)
├── Form1.cs                 # Login form (authentication entry point)
├── Form1.Designer.cs        # Login UI designer layout
├── Form1.resx               # Login UI resources
├── Form2.cs                 # Main control dashboard logic (Serial port, telemetry, control)
├── Form2.Designer.cs        # Dashboard UI designer layout (LED indicators, dials, logs)
├── Form2.resx               # Dashboard UI resources
├── JoystickControl.cs       # Custom WinForms UserControl for virtual GUI joystick
├── Program.cs               # Application entry point
├── Properties/
│   ├── AssemblyInfo.cs      # Assembly metadata
│   ├── Resources.resx       # Application resources
│   └── Settings.settings    # Application settings
├── Robot.csproj             # C# project definition
├── Robot.slnx               # Visual Studio solution file
├── code/
│   └── code.ino             # Arduino Mega firmware (AccelStepper, Servo, state machine)
├── .gitignore               # Git ignore rules for Visual Studio and Arduino
└── README.md                # Project documentation
```

---

## Requirements

### Software
- **Visual Studio** (2019, 2022, or newer) with the **.NET desktop development** workload.
- **.NET Framework 4.7.2** Developer Pack / Runtime.
- **Arduino IDE** (v1.8.x or v2.x).
- **Arduino Libraries**:
  - [`AccelStepper`](https://www.airspayce.com/mikem/arduino/AccelStepper/) (install via Arduino Library Manager).
  - `Servo` (built-in standard library).

### Hardware
- **Microcontroller**: Arduino Mega 2560 (or compatible board with adequate I/O and hardware serial).
- **Actuators**:
  - 2x Stepper motors (e.g., driven by TB6600 and A4988 motor drivers).
  - 4x Servo motors (pins D51, D49, D47, D45).
- **Sensors & Inputs**:
  - 4x Limit switches for Axis 1 & Axis 2 Min/Max boundaries.
  - Physical buttons: START 1, START 2, STOP (Emergency), HOME, TOGGLE MODE.
  - Analog joystick (A4, A5) and 4x 10k potentiometers (A0–A3).
  - Status LEDs (Ready, Running, Manual HW, Manual GUI, Emergency Stop).
- **USB Cable**: Type-A to Type-B for PC serial communication.

---

## Hardware Pinout Reference (Arduino Mega)

| Component | Arduino Pin | Description |
|:---|:---|:---|
| **Stepper 1 (PUL / DIR / ENA)** | 3 / 12 / 11 | Axis 1 (TB6600 driver) |
| **Stepper 2 (PUL / DIR / ENA)** | 43 / 41 / 10 | Axis 2 (A4988 driver) |
| **Limit Switches** | 22 (Min 1), 24 (Max 1), 26 (Min 2), 28 (Max 2) | Active LOW |
| **Pushbuttons** | 34 (Start 1), 36 (Start 2), 30 (Stop), 32 (Home), 38 (Toggle Mode) | Active LOW (PULLUP) |
| **Servos 1–4** | 51, 49, 47, 45 | PWM Control |
| **Analog Inputs** | A4 (Joy X), A5 (Joy Y), A0–A3 (Pot 1–4) | Manual HW Control |
| **Status LEDs** | 4 (Ready), 6 (Running), 7 (Manual HW), 5 (Stop), 8 (Manual GUI) | Indicator lights |

---

## How to Use

1. **Upload Arduino Firmware**:
   - Open `code/code.ino` in the Arduino IDE.
   - Select **Tools > Board > Arduino Mega or Mega 2560**.
   - Select the corresponding COM port.
   - Click **Upload**.

2. **Connect Hardware**:
   - Ensure the Arduino Mega is connected to your PC via USB.
   - Power on the external motor driver power supply.

3. **Launch the WinForms Control App**:
   - Open `Robot.slnx` in Visual Studio and build the solution (`Ctrl + Shift + B`), or run the application (`F5`).
   - On the login screen (`Form1`), click **Đăng nhập** to proceed to the main dashboard.

4. **Operate the Robot**:
   - Select your Arduino's **COM Port** (e.g., `COM3`) and set the **Baudrate** to `115200`.
   - Click **Kết nối** (Connect).
   - Once connected, press **Home** (`H`) to initialize and home both stepper axes.
   - Use the interface buttons to trigger automated cycles (`Cycle 1`, `Cycle 2`), switch to manual modes (`Toggle Mode`), or use the virtual joystick and servo trackbars for manual positioning.
   - In case of an anomaly, press the red **STOP** button immediately.

---

## License

This project is licensed under the MIT License - see the LICENSE file for details if applicable.
