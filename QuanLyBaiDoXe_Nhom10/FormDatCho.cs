using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace QuanLyBaiDoXe_Nhom10
{
    public partial class FormDatCho : Form
    {
        private DatCho datCho;
        private GiaoDienChinh dienChinh;
        List<System.Windows.Forms.Button> DanhSachChon = new List<System.Windows.Forms.Button>();
        private string pheptoan;
        internal static string NgayDatCho;
        internal static double TongTien;
        internal static string NgayDuKien;
        internal static string PhuongThuc;
        internal static string HoTen;

        public FormDatCho()
        {
            InitializeComponent();
            datCho = new DatCho(this);
            dienChinh = new GiaoDienChinh();
            
        }

       

        private void btnChon1_Click(object sender, EventArgs e)
        {
            if (btnChon1.BackColor != Color.Yellow)
            {
                if (btnChon1.BackColor == Color.White)
                {
                    btnChon1.BackColor = Color.Blue;
                    datCho.SetTextBoxText("VT-1");
                    datCho.ShowDialog();
                    this.Close();


                }
                else
                {
                    btnChon1.BackColor = Color.White;
                    DanhSachChon.Remove(btnChon1);
                }
            }
            else
            {
                MessageBox.Show("Đã có người chọn");
            }
        }

        private void btnChon2_Click(object sender, EventArgs e)
        {

            if (btnChon2.BackColor != Color.Yellow)
            {
                if (btnChon2.BackColor == Color.White)
                {
                    btnChon2.BackColor = Color.Blue;
                    datCho.SetTextBoxText("VT-2");
                    datCho.Show();
                    this.Close();

                }
                else
                {
                    btnChon2.BackColor = Color.White;
                    DanhSachChon.Remove(btnChon2);
                }
            }
            else
            {
                MessageBox.Show("Đã có người chọn");
            }
        }

        private void btnChon3_Click(object sender, EventArgs e)
        {
            if (btnChon3.BackColor != Color.Yellow)
            {
                if (btnChon3.BackColor == Color.White)
                {
                    btnChon3.BackColor = Color.Blue;
                    datCho.SetTextBoxText("VT-3");
                    datCho.ShowDialog();
                    this.Close();

                }
                else
                {
                    btnChon3.BackColor = Color.White;
                    DanhSachChon.Remove(btnChon3);
                }
            }
            else
            {
                MessageBox.Show("Đã có người chọn");
            }
        }

        private void btnChon4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    datCho.SetTextBoxText("VT-4");
                    datCho.ShowDialog();
                    this.Close();

                }
                else
                {
                    btn.BackColor = Color.White;
                    DanhSachChon.Remove(btn);
                }
            }
            else
            {
                MessageBox.Show("Đã có người chọn");
            }
        }

        private void btnChon5_Click(object sender, EventArgs e)
        {
            if (btnChon5.BackColor != Color.Yellow)
            {
                if (btnChon5.BackColor == Color.White)
                {
                    btnChon5.BackColor = Color.Blue;
                    datCho.SetTextBoxText("VT-5");
                    datCho.ShowDialog();
                    this.Close();

                }
                else
                {
                    btnChon5.BackColor = Color.White;
                    DanhSachChon.Remove(btnChon5);
                }
            }
            else
            {
                MessageBox.Show("Đã có người chọn");
            }
        }

        private void btnChon6_Click(object sender, EventArgs e)
        {

            if (btnChon6.BackColor != Color.Yellow)
            {
                if (btnChon6.BackColor == Color.White)
                {
                    btnChon6.BackColor = Color.Blue;
                    datCho.SetTextBoxText("VT-6");
                    datCho.ShowDialog();
                    this.Close();
                }
                else
                {
                    btnChon6.BackColor = Color.White;
                    DanhSachChon.Remove(btnChon6);
                }
            }
            else
            {
                MessageBox.Show("Đã có người chọn");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public event Action ThanhToanHoanTat;
        private void button3_Click(object sender, EventArgs e)
        {
            ThanhToanHoanTat?.Invoke();
            string hoTen = HoTen;
            string phuongThuc = PhuongThuc;
            string ngayDuKien = NgayDuKien;
            double tongTien = TongTien;

            MessageBox.Show($"Thông tin thanh toán:\nHọ tên: {hoTen}\nPhương thức: {phuongThuc}\nNgày dự kiến: {ngayDuKien}\nTổng tiền: {tongTien}");

            
          

            ThanhToanHoanTat?.Invoke();
        }




        private void DatCho_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
