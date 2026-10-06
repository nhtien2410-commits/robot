using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Robot // Hãy đổi lại tên này nếu Namespace dự án của bạn khác đi
{
    public class JoystickControl : UserControl
    {
        private Point knobPosition; // Vị trí hiện tại của núm xoay
        private bool isDragging = false; // Trạng thái đang giữ chuột
        private const int joystickRadius = 50; // Bán kính vòng tròn nền bên ngoài
        private const int knobRadius = 18; // Bán kính núm tròn điều khiển bên trong

        // Định nghĩa Sự kiện để Form chính "lắng nghe" dữ liệu tọa độ X, Y (-100 đến 100)
        public event Action<int, int> OnJoystickMove;

        public JoystickControl()
        {
            // Thiết lập kích thước mặc định cho Joystick
            this.Size = new Size(130, 130);
            // Kích hoạt DoubleBuffered để giao diện mượt mà, không bị nhấp nháy khi vẽ lại liên tục
            this.DoubleBuffered = true;
            ResetKnobToCenter();
        }

        private void ResetKnobToCenter()
        {
            knobPosition = new Point(this.Width / 2, this.Height / 2);
        }

        // --- BƯỚC VẼ GIAO DIỆN (Được gọi tự động khi dùng lệnh Invalidate) ---
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Bật khử răng cưa cho nét vẽ mượt

            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            // 1. Vẽ vòng tròn nền (Outer Circle) - ĐÃ SỬA LỖI 45f TẠI ĐÂY
            using (LinearGradientBrush bgBrush = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(240, 240, 240), Color.FromArgb(200, 200, 200), 45f))
            {
                g.FillEllipse(bgBrush, centerX - joystickRadius, centerY - joystickRadius, joystickRadius * 2, joystickRadius * 2);
            }
            using (Pen borderPen = new Pen(Color.FromArgb(160, 160, 160), 2))
            {
                g.DrawEllipse(borderPen, centerX - joystickRadius, centerY - joystickRadius, joystickRadius * 2, joystickRadius * 2);
            }

            // 2. Vẽ các trục chữ thập mờ định hướng (Tùy chọn - nhìn cho trực quan)
            using (Pen axisPen = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                g.DrawLine(axisPen, centerX - joystickRadius, centerY, centerX + joystickRadius, centerY);
                g.DrawLine(axisPen, centerX, centerY - joystickRadius, centerX, centerY + joystickRadius);
            }

            // 3. Vẽ Núm điều khiển (Knob) dựa vào vị trí biến knobPosition - ĐÃ SỬA LỖI 90f TẠI ĐÂY
            Rectangle knobRect = new Rectangle(knobPosition.X - knobRadius, knobPosition.Y - knobRadius, knobRadius * 2, knobRadius * 2);
            using (LinearGradientBrush knobBrush = new LinearGradientBrush(knobRect, Color.FromArgb(100, 110, 120), Color.FromArgb(50, 55, 60), 90f))
            {
                g.FillEllipse(knobBrush, knobRect);
            }
            g.DrawEllipse(Pens.Black, knobRect);
        }

        // --- XỬ LÝ SỰ KIỆN CHUỘT ---
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // Chỉ kích hoạt kéo nếu người dùng click trúng hoặc gần núm điều khiển
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;
            double distance = Math.Sqrt(Math.Pow(e.X - centerX, 2) + Math.Pow(e.Y - centerY, 2));

            if (distance <= joystickRadius)
            {
                isDragging = true;
                UpdateJoystick(e.Location);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging)
            {
                UpdateJoystick(e.Location);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isDragging = false;
            ResetKnobToCenter(); // Thả chuột ra -> Núm tự động nhảy về tâm
            this.Invalidate();   // Vẽ lại
            OnJoystickMove?.Invoke(0, 0); // Gửi giá trị (0,0) báo hiệu dừng động cơ bước
        }

        // Hàm tính toán vị trí giới hạn của núm và xuất tọa độ phần trăm
        private void UpdateJoystick(Point mousePos)
        {
            int centerX = this.Width / 2;
            int centerY = this.Height / 2;

            // Tính khoảng cách từ vị trí chuột tới tâm hình tròn
            double distance = Math.Sqrt(Math.Pow(mousePos.X - centerX, 2) + Math.Pow(mousePos.Y - centerY, 2));

            if (distance <= joystickRadius)
            {
                knobPosition = mousePos;
            }
            else
            {
                // Nếu chuột kéo vượt biên, giới hạn núm nằm ở rìa vòng tròn
                double angle = Math.Atan2(mousePos.Y - centerY, mousePos.X - centerX);
                knobPosition.X = centerX + (int)(joystickRadius * Math.Cos(angle));
                knobPosition.Y = centerY + (int)(joystickRadius * Math.Sin(angle));
            }

            this.Invalidate(); // Ép linh kiện chạy lại hàm OnPaint để cập nhật đồ họa hiển thị

            // TÍNH TOÁN GIÁ TRỊ XUẤT RA (-100 đến 100)
            int pctX = (knobPosition.X - centerX) * 100 / joystickRadius;
            int pctY = (centerY - knobPosition.Y) * 100 / joystickRadius; // Đảo chiều Y để kéo lên trên là Dương (+)

            // Kích hoạt sự kiện để Form chính nhận được dữ liệu
            OnJoystickMove?.Invoke(pctX, pctY);
        }

        // Đảm bảo nút luôn cân đối nếu bị thay đổi kích thước thủ công
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ResetKnobToCenter();
            this.Invalidate();
        }
    }
}