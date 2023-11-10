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
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtTaiKhoan.Text == "") || (txtMatKhau.Text == ""))
            {
                MessageBox.Show("Vui long nhap thong tin", "thong bao");
            }
            else
            {
                if ((txtTaiKhoan.Text == "admin") && (txtMatKhau.Text == "123"))
                {
                    MessageBox.Show("Dang nhap thanh cong", "thong bao");
                    MAIN mAIN = new MAIN();
                    mAIN.ShowDialog();
                }
                else
                {
                    MessageBox.Show("sai tai khoan hoac mat khau, vui long dang nhap lai", "thong bao");
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DANGKI dANGKI = new DANGKI();
            dANGKI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
