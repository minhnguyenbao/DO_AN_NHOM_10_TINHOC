using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBaiDoXe_Nhom10
{
 
    public partial class DatCho : Form
    {
        private FormDatCho formDatCho;
        List<string> listGT = new List<string>() { "Ô tô 4 chỗ", "Ô tô 7 chỗ" };
        private List<CDATCHO> dsDC = new List<CDATCHO>();
        //private DataTable dataTable;
        private CDATCHO ttdc;
        private DatCho datCho;
       
        private string thongTinThanhToan;

        public CDATCHO DuLieuDongDuocChon { get; private set; }

        public DatCho(FormDatCho formDatCho)
        {
            InitializeComponent();
            ttdc = new CDATCHO();
            this.formDatCho = formDatCho;
        }

        
        public void SetTextBoxText(string text)
        {
            txtVitri.Text = text;
        }


        private void DatCho_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\dsDC.dat";
            dsDC = LuuFIle.DocFile_DC(path);
            hienDSDatCho();
            cbLoaiXe.DataSource = listGT;
            


        }
        private void hienDSDatCho()
        {
            dgvDatCho.DataSource = dsDC.Select(dc => new { dc.MaKH, dc.TenKH, dc.CCCD, dc.SDT, dc.DiaChi, dc.Loaixe, dc.Vitri, dc.TGDatCho ,dc.SoTienDaThanhToan }).ToList();

        }
        private void btnChonCho_Click(object sender, EventArgs e)
        {
            FormDatCho datCho = new FormDatCho();
            datCho.Show();
            
        }
        public object ThanhToanHoanTat { get; private set; }
        public object MaKH { get; internal set; }
        public object TongTien { get; internal set; }

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            if(txtMa.Text=="")
            {
                MessageBox.Show("Hãy nhập mã số khách hàng!", "Thông báo");
                txtMa.Focus();
                return;
            }
            
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng!", "Thông báo");
                txtTenKH.Focus();
                return;
            }
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Hãy nhập số căn cước công dân khách hàng!", "Thông báo");
                txtCCCD.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Hãy nhập số điện thoại!", "Thông báo");
                txtSDT.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Hãy nhập địa chỉ!", "Thông báo");
                txtDiaChi.Focus();
                return;
            }
            CDATCHO DC = new CDATCHO();
            DC.MaKH = txtMa.Text;
            DC.TenKH = txtTenKH.Text;
            DC.CCCD = txtCCCD.Text;
            DC.SDT = txtSDT.Text;
            DC.DiaChi = txtDiaChi.Text;
            DC.Loaixe = cbLoaiXe.Text;
            DC.Vitri = txtVitri.Text;
            ttdc.DatCho();
            if (tim(DC.MaKH) == null)
            {
                dsDC.Add(DC);
                hienDSDatCho();
            }
            else
            {
                MessageBox.Show("Mã khách hàng đã tồn tại. Kông thể thêm");
            }
            string path = Application.StartupPath + "\\dsDC.dat";
            bool kt = LuuFIle.LuuFile_DC(dsDC, path);
            if (kt == true)
            {
                MessageBox.Show("Đặt chỗ thành công");
            }
            txtTenKH.Clear();
            txtMa.Clear();
            txtVitri.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

        


        private void ThanhToan()
        {
            if (DuLieuDongDuocChon != null)
            {                
                if (DuLieuDongDuocChon.DaThanhToan)
                {
                    MessageBox.Show("Khách hàng đã thanh toán rồi. Không thể thanh toán lại.");
                    return;
                }

                ttdc.LayXe();
                TimeSpan tgGiua = ttdc.TGLayXe - ttdc.TGDatCho;
                double soGio = tgGiua.TotalMinutes;
                string tb = $"Thời gian gửi xe: {tgGiua.Hours} giờ {tgGiua.Minutes} phút";
                MessageBox.Show(tb);

                DialogResult result;
                int soTienThanhToan = (soGio < 360) ? 20000 : 100000;

                result = MessageBox.Show($"Bạn có chắc chắn muốn thanh toán {soTienThanhToan} VND?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DuLieuDongDuocChon.ThanhToan();
                    DuLieuDongDuocChon.DaThanhToan = true; // Đặt trạng thái thanh toán thành true
                    DuLieuDongDuocChon.SoTienDaThanhToan = soTienThanhToan; // Gán giá trị cho thuộc tính SoTienDaThanhToan

                    MessageBox.Show($"Thanh toán thành công. Số tiền đã thanh toán: {soTienThanhToan} VND", "Thông báo");
                    dgvDatCho.FirstDisplayedScrollingRowIndex = dgvDatCho.Rows.Count - 1;
                    hienDSDatCho();
                    string path = Application.StartupPath + "\\dsDC.dat";
                    bool kt = LuuFIle.LuuFile_DC(dsDC, path);
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng muốn thanh toán.");
            }
        }




        private void btThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }



        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;

            if (tim(ma) != null)
            {
                CDATCHO kh = new CDATCHO();
                dsDC.Remove(tim(ma));
                hienDSDatCho();

            }
            else
                MessageBox.Show("Mã khách hàng không tồn tại! Không thể xóa.");
        }
        private CDATCHO tim(string ma)
        {
            for (int i = 0; i < dsDC.Count; i++)
            {
                if (ma == dsDC[i].MaKH)
                    return dsDC[i];
            }
            return null;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            CDATCHO dc = new CDATCHO();
            dc.MaKH = txtMa.Text;

            if (tim(dc.MaKH) != null)
            {
                CDATCHO b = new CDATCHO();
                b = tim(dc.MaKH);
                b.TenKH = txtTenKH.Text;
                b.CCCD = txtCCCD.Text;
                b.SDT = txtSDT.Text;
                b.DiaChi = txtDiaChi.Text;
                b.Loaixe = cbLoaiXe.Text;
                b.Vitri=txtVitri.Text;
                hienDSDatCho();

            }
            else
                MessageBox.Show("Mã khách hàng không tồn tại! Không thể cập nhật thông tin.");
        }

        private void dgvDatCho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dsDC.Count)
            {
                DuLieuDongDuocChon = dsDC[e.RowIndex];               
                txtMa.Text = DuLieuDongDuocChon.MaKH;
                txtTenKH.Text = DuLieuDongDuocChon.TenKH;               
                txtVitri.Text = DuLieuDongDuocChon.Vitri;
                txtCCCD.Text = DuLieuDongDuocChon.CCCD;
                cbLoaiXe.Text = DuLieuDongDuocChon.Loaixe;
                txtSDT.Text = DuLieuDongDuocChon.SDT;
                txtDiaChi.Text = DuLieuDongDuocChon.DiaChi;
                
            }
        }


        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            if (txtCCCD.Text.Length != 12)
            {
                MessageBox.Show("Vui lòng nhập đúng số căn cước công dân. CCCD phải có đủ 12 số");
                e.Cancel = true;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\dsDC.dat";
            bool kt = LuuFIle.LuuFile_DC(dsDC, path);
            if (kt == true)
            {
                MessageBox.Show("Lưu thành công");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại. SDT phải có đủ 10 số");
                e.Cancel = true;
            }
        }
    }
}
