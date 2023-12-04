using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    

    public partial class NhanVien : Form
    {
        CXulyNhanVien xulyNhanVien = new CXulyNhanVien();
        private void HienThiDSNhanVien()
        {
            dgvNhanVien.DataSource= xulyNhanVien.layDSNhanVien();
        }
        private CNhanVien timNV(string ma)
        {
            try
            {
                return xulyNhanVien.tim(ma);
            }
            catch
            {
                return null;
            }
        }
        public NhanVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            xulyNhanVien.docFile("dsNV.bin");
            loadFile();
            HienThiDSNhanVien();
        }

        

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma=txtMaNV.Text;
            if (xulyNhanVien.tim(ma) != null)
            {
                xulyNhanVien.xoa(ma);
                HienThiDSNhanVien();
            }
            else
                MessageBox.Show("Không tìm thấy nhân viên cần xóa");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            CNhanVien nv=xulyNhanVien.tim(ma);
            if (nv != null)
            {
                nv.TenNV = txtTenNV.Text;
                nv.NgaySinh = dtNgaySinh.Value;
                nv.GioiTinh = rNam.Checked;
                nv.CCCD = txtCCCD.Text;
                nv.SDT = txtSDT.Text;
                nv.DiaChi = txtDiaChi.Text;
                xulyNhanVien.sua(nv);
                HienThiDSNhanVien() ;

            }
            else
                MessageBox.Show("Mã nhân viên không tồn tại! Không thể cập nhật thông tin.");
        }

        private void dgvNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtNgaySinh.Value = (DateTime)dgvNhanVien.Rows[e.RowIndex].Cells[2].Value;
            rNam.Checked = (bool)dgvNhanVien.Rows[e.RowIndex].Cells[3].Value;
            txtCCCD.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            xulyNhanVien.ghiFile("dsNV.bin");
        }
        private void loadFile()
        {
            xulyNhanVien.docFile("dsNV.bin");
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var grid =(DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name=="Giới tính")
            {
                if(e.Value is bool)
                {
                    bool value=(bool)e.Value;
                    e.Value = (value) ? "Nam" : "Nu";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            CNhanVien nv = new CNhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.NgaySinh = dtNgaySinh.Value;
            nv.GioiTinh = rNam.Checked;
            nv.CCCD = txtCCCD.Text;
            nv.SDT = txtSDT.Text;
            nv.DiaChi = txtDiaChi.Text;
            if (timNV(nv.MaNV) == null)
            {
                xulyNhanVien.them(nv);

                HienThiDSNhanVien();
            }
            else
                MessageBox.Show("Mã nhân viên " + nv.MaNV + " đã tồn tại!");
        }
    }
}
