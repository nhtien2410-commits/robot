using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class Form2 : Form
    {
        public bool isThoat = true;
        public event EventHandler Dangxuat;
        bool isConnected = false;

        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            cbobaudrate.Items.AddRange(new string[] { "9600", "115200" });
            cbocom.Items.AddRange(new string[] { "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM9" });
        }

        private void butdangxuat_Click(object sender, EventArgs e) => Dangxuat?.Invoke(this, EventArgs.Empty);
        private void butthoat_Click(object sender, EventArgs e) { if (isThoat) Application.Exit(); }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e) { if (isThoat) Application.Exit(); }

        private void butketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sercom.IsOpen) sercom.Close();

                sercom.PortName = cbocom.Text;
                sercom.BaudRate = int.Parse(cbobaudrate.Text);
                sercom.Open();

                isConnected = true;
                lbtrangthai.Text = "Đã kết nối";
                lbtrangthai.ForeColor = Color.Green;
                timerLog.Start();
                sercom.DataReceived += DataReceive;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi kết nối: " + ex.Message); }
        }

        private void butngat_Click(object sender, EventArgs e)
        {
            if (sercom.IsOpen) sercom.Close();
            timerLog.Stop();
            isConnected = false;
            lbtrangthai.Text = "Đã ngắt";
            lbtrangthai.ForeColor = Color.Red;
        }

        private void DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            // Kiểm tra an toàn trước khi đọc
            if (sercom == null || !sercom.IsOpen) return;

            try
            {
                // Đọc toàn bộ dữ liệu đang có trong bộ đệm dòng
                string data = sercom.ReadLine();

                // Kiểm tra dữ liệu hợp lệ trước khi đẩy lên giao diện
                if (!string.IsNullOrEmpty(data))
                {
                    this.BeginInvoke(new Action(() => ProcessData(data.Trim())));
                }
            }
            catch (System.IO.IOException)
            {
                // Bỏ qua lỗi này vì đây là lỗi do luồng bị hủy/đóng đột ngột (Aborted)
            }
            catch (Exception ex)
            {
                // Chỉ hiện thông báo với các loại lỗi nghiêm trọng khác
                this.BeginInvoke(new Action(() => {
                    lbtrangthai.Text = "Lỗi kết nối";
                    lbtrangthai.ForeColor = Color.Orange;
                }));
            }
        }

        private void ProcessData(string data)
        {
            if (string.IsNullOrEmpty(data)) return;

            // Cập nhật trạng thái chữ
            if (data.StartsWith("STATE_CHANGED:"))
            {
                // THÊM .Trim() ở đây để xóa khoảng trắng thừa đầu/cuối chuỗi trạng thái
                string status = data.Substring(14).Trim();
                txtRobotState.Text = status;

                // Reset tất cả các đèn về màu xám (tắt)
                pnlLedReady.BackColor = Color.DarkGray;
                pnlLedRunning.BackColor = Color.DarkGray;
                pnlLedManualHW.BackColor = Color.DarkGray;
                pnlLedManualGUI.BackColor = Color.DarkGray;
                pnlLedStop.BackColor = Color.DarkGray;

                // Cập nhật màu sắc đèn LED chính xác tuyệt đối
                switch (status)
                {
                    case "INIT": pnlLedReady.BackColor = Color.Yellow; break;
                    case "RUNNING": pnlLedRunning.BackColor = Color.Lime; break;
                    case "HOMING": pnlLedReady.BackColor = Color.Yellow; break;
                    case "AUTOMATIC": pnlLedReady.BackColor = Color.Yellow; break;
                    case "EMERGENCY_STOP": pnlLedStop.BackColor = Color.Red; break;
                    case "MANUAL_HARDWARE": pnlLedManualHW.BackColor = Color.Lime; break;
                    case "MANUAL_GUI": pnlLedManualGUI.BackColor = Color.Lime; break;
                }
            }
            // Cập nhật góc Servo: FB_S:ID,ANGLE
            else if (data.StartsWith("FB_S:"))
            {
                string[] parts = data.Substring(5).Split(',');
                if (parts.Length == 2)
                {
                    string val = parts[1].Trim() + "°";
                    switch (parts[0].Trim())
                    {
                        case "1": txtServo1.Text = val; break;
                        case "2": txtServo2.Text = val; break;
                        case "3": txtServo3.Text = val; break;
                        case "4": txtServo4.Text = val; break;
                    }
                }
            }
            // Cập nhật tọa độ Stepper: FB_STEP:X,Y
            else if (data.StartsWith("FB_STEP:"))
            {
                string[] parts = data.Substring(8).Split(',');
                if (parts.Length == 2)
                {
                    txtStepperX.Text = parts[0].Trim() + " Steps";
                    txtStepperY.Text = parts[1].Trim() + " Steps";
                }
            }
        }

        private void GuiLenhSerial(string chuoiLenh)
        {
            if (sercom.IsOpen && isConnected) sercom.Write(chuoiLenh + "\n");
        }

        private void butToggleMode_Click_1(object sender, EventArgs e) => GuiLenhSerial("M");
        private void butHome_Click_1(object sender, EventArgs e) => GuiLenhSerial("H");
        private void butStart1_Click_1(object sender, EventArgs e) => GuiLenhSerial("1");
        private void butStart2_Click_1(object sender, EventArgs e) => GuiLenhSerial("2");
        private void butStop_Click_1(object sender, EventArgs e) => GuiLenhSerial("E");

        private void joystickControl1_OnJoystickMove(int x, int y)
        {
            if (isConnected) GuiLenhSerial($"J:{x},{y}");
        }

        private void trackServo_Scroll(object sender, EventArgs e)
        {
            if (!isConnected) return;
            TrackBar tb = (TrackBar)sender;
            int id = tb.Name.EndsWith("1") ? 1 : tb.Name.EndsWith("2") ? 2 : tb.Name.EndsWith("3") ? 3 : 4;
            GuiLenhSerial($"S:{id},{tb.Value}");
        }

        private void butreset_Click(object sender, EventArgs e) => lvRobotLog.Items.Clear();

        private void AddLogToListView()
        {
            // Tạo một dòng mới với cột đầu tiên là Ngày
            ListViewItem item = new ListViewItem(DateTime.Now.ToString("dd/MM/yyyy"));

            // Thêm các cột tiếp theo (SubItems) theo đúng thứ tự thiết kế trong Designer
            item.SubItems.Add(DateTime.Now.ToString("HH:mm:ss"));
            item.SubItems.Add(txtStepperX.Text.Replace(" Steps", ""));
            item.SubItems.Add(txtStepperY.Text.Replace(" Steps", ""));
            item.SubItems.Add(txtServo1.Text.Replace("°", ""));
            item.SubItems.Add(txtServo2.Text.Replace("°", ""));
            item.SubItems.Add(txtServo3.Text.Replace("°", ""));
            item.SubItems.Add(txtServo4.Text.Replace("°", ""));
            item.SubItems.Add(txtRobotState.Text);

            // Chèn dòng mới vào đầu danh sách
            lvRobotLog.Items.Insert(0, item);

            // Giới hạn số lượng dòng (ví dụ 100 dòng) để tránh làm chậm giao diện
            if (lvRobotLog.Items.Count > 100) lvRobotLog.Items.RemoveAt(100);
        }

        private void timerLog_Tick(object sender, EventArgs e)
        {
            if (isConnected) AddLogToListView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbgio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}