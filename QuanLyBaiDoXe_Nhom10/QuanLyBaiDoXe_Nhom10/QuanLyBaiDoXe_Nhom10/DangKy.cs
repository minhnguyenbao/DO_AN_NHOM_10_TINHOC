using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiDoXe_Nhom10
{
    public partial class DangKy : Form
    {
        private const string fileName = "account.txt";
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string username = txt_TenTK.Text;
            string password = txt_MK.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.");
                return;
            }


            if (IsUsernameExists(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn một tên khác.");
                return;
            }
            SaveAccountInfo(username, password);
            MessageBox.Show("Đăng ký thành công!");
            this.Close();
            Form1 f = new Form1();
            f.ShowDialog();
            f.Hide();
        }
        private bool IsUsernameExists(string username)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i += 2)
                {
                    if (lines[i] == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void SaveAccountInfo(string username, string password)
        {

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(username);
                writer.WriteLine(password);

            }
        }
    }
}
