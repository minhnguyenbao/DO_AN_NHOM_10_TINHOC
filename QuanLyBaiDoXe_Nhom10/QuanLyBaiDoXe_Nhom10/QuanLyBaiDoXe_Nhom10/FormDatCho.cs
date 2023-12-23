using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace QuanLyBaiDoXe_Nhom10
{
    public partial class FormDatCho : Form
    {
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
            
        }

        private void FormDatCho_Load(object sender, EventArgs e)
        {

        }
     
        private void btnDatCho_Click(object sender, EventArgs e)
        {

        }

        private void btnChon1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
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

        private void btnChon2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
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

        private void btnChon3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
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

        private void btnChon4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
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
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
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

        private void btnChon6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn.BackColor != Color.Yellow)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                    DanhSachChon.Add(btn);
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

    }
}
