using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string tenTK = "admin";
        string MK = "123456";
        public Form1()
        {
            InitializeComponent();
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if (tenTK == null || tenTK.Equals(""))
                MessageBox.Show("Hãy nhập tên tài khoản");
            if (MK == null || MK.Equals(""))
                MessageBox.Show("Hãy nhập mật khẩu");
            if (kiemTraDangNhap(txtTK.Text, txtMK.Text))
            {
                MessageBox.Show("Đăng nhập thành công");
                QLBaiDoXe sh = new QLBaiDoXe();
                sh.ShowDialog();
                sh.Hide();
            }
            else
                MessageBox.Show("Tên tài khoản hoặc mật khẩu sai!");
        }
        bool kiemTraDangNhap(string tk, string mk)
        {
            if (this.tenTK == tk && this.MK == mk)
                return true;
            return false;
        }

        private void dangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
