using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiDoXe_Nhom10
{
    public partial class KhachHang : Form
    {

        private List<CKhachHang> dsKH=new List<CKhachHang>();
        private void HienThiKhachHang()
        {
            dgvKhachHang.DataSource = dsKH.ToList();

        }
        private CKhachHang timKH(string ma)
        {
            for(int i=0;i<dsKH.Count; i++)
            {
                if (ma == dsKH[i].MaKH)
                    return dsKH[i];
            }
            return null;
        }
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.dat";
            dsKH = LuuFIle.DocFile(path);
            HienThiKhachHang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string phai = "";
            CKhachHang kh = new CKhachHang();
            kh.MaKH = txtMaKH.Text;
            kh.TenKH = txtTenKH.Text;
            kh.NgaySinh = dtNgaySinh.Value;
            if (rNam.Checked == true)
            {
                phai = "Nam";
            }
            if (rNu.Checked == true)
                phai = "Nữ";
            kh.GioiTinh = phai;
            kh.CCCD = txtCCCD.Text;
            kh.SDT = txtSDT.Text;
            kh.DiaChi = txtDiaChi.Text;
            kh.LoaiXe = cbLoaiXe.Text;
            if (timKH(kh.MaKH) == null)
            {
                dsKH.Add(kh);

                HienThiKhachHang();
            }
            else
                MessageBox.Show("Mã nhân viên " + kh.MaKH + " đã tồn tại!");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            
            if (timKH(ma)!=null)
            {
                CKhachHang kh = new CKhachHang();
                dsKH.Remove(timKH(ma));
                HienThiKhachHang();

            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại! Không thể xóa.");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            CKhachHang kh =new CKhachHang();
            kh.MaKH= txtMaKH.Text;
            
            if (timKH(kh.MaKH)!=null)
            {
                string phai = "";

                CKhachHang b = new CKhachHang();
                b = timKH(kh.MaKH);
                b.TenKH = txtTenKH.Text;
                b.NgaySinh = dtNgaySinh.Value;
                if (rNam.Checked == true)
                {
                    phai = "Nam";
                }
                if (rNu.Checked == true)
                    phai = "Nữ";
                b.GioiTinh = phai;
                b.CCCD = txtCCCD.Text;
                b.SDT = txtSDT.Text;
                b.DiaChi = txtDiaChi.Text;
                b.LoaiXe = cbLoaiXe.Text;
                HienThiKhachHang() ;

            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại! Không thể cập nhật thông tin.");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.dat";
            bool kt = LuuFIle.LuuFile(dsKH, path);
            if(kt==true)
            {
                MessageBox.Show("Lưu thành công");
            }
        }
        
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            //rNam.Checked = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
            //            txtMaNSX.Text =
            //dgvNSX.Rows[e.RowIndex].Cells[0].Value.ToString();
            //            txtTenNSX.Text =
            //           dgvNSX.Rows[e.RowIndex].Cells[1].Value.ToString();
            //            txtSoDT.Text = dgvNSX.Rows[e.RowIndex].Cells[2].Value.ToString();
            //            txtDiaChi.Text =
            //           dgvNSX.Rows[e.RowIndex].Cells[3].Value.ToString()
        }

       
       

    }
}
