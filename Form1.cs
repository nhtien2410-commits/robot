using Robot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robot
{
    public partial class Form1 : Form
    {
        string tentaikhoan = "";
        string matkhau = "";
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }
        private void F_Dangxuat(object sender, EventArgs e)
        {
            (sender as Form2).isThoat = false;
            (sender as Form2).Close();
            this.Show();
        }
        private void butdangnhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txttaikhoan.Text, txtmatkhau.Text))
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
                f.Dangxuat += F_Dangxuat;

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi");
                txttaikhoan.Focus();

            }
        }
        private void picdong_Click_1(object sender, EventArgs e)
        {
            if (txtmatkhau.PasswordChar == '*')
            {
                pictmo.BringToFront();
                txtmatkhau.PasswordChar = '\0';
            }
        }

        private void pictmo_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.PasswordChar == '*')
            {
                pictmo.BringToFront();
                txtmatkhau.PasswordChar = '\0';
            }
        }
    }
}
