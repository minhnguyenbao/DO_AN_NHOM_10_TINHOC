using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiDoXe_Nhom10
{
    public partial class Form1 : Form
    {
        private const string fileName = "account.txt";
        public static List<CKhachHang> CustomerList { get; set; } = new List<CKhachHang>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            string username = txtTK.Text;
            string password = txtMK.Text;

            
            if (CheckLogin(username, password))
            {
                MessageBox.Show($"Đăng nhập thành công!");
                GiaoDienChinh mainForm = new GiaoDienChinh();
                mainForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Kiểm tra lại thông tin tài khoản.");
            }
        }
        private bool CheckLogin(string username, string password)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i += 2)
                {
                    if (lines[i] == username && lines[i + 1] == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void dangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.ShowDialog();
        }
    }
}
