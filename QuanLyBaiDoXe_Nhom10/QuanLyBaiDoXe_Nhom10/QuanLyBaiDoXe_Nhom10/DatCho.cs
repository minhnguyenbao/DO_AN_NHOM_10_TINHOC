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
 
    public partial class DatCho : Form
    {
        private List<CDATCHO> dsDC = new List<CDATCHO>();
        private DataTable dataTable;
        private static DatCho _instance = null;
        private CDATCHO ttdc;

        public CDATCHO DuLieuDongDuocChon { get; private set; }

        public DatCho()
        {
            InitializeComponent();
            ttdc = new CDATCHO();
            dataTable = new DataTable();
            dataTable.Columns.Add("Vị trí");
            dgvDatCho.DataSource = dataTable;
        }
        private DataGridViewCellEventHandler DataGridViewCellEventHandler(DataGridViewCellEventHandler cellClick)
        {
            throw new NotImplementedException();
        }
        private void DatCho_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\dsDC.dat";
            dsDC = LuuFIle.DocFile_DC(path);
            hienDSDatCho();
            dgvDatCho.CellClick += dgvDatCho_CellClick;


        }
        private void hienDSDatCho()
        {
            dgvDatCho.DataSource = dsDC.ToList();
            
        }
        private void btnChonCho_Click(object sender, EventArgs e)
        {
            FormDatCho datCho = new FormDatCho();
            datCho.Show();
        }
        public object ThanhToanHoanTat { get; private set; }
        private void btnDatCho_Click(object sender, EventArgs e)
        {
            CDATCHO DC = new CDATCHO();
            DataRow newRow = dataTable.NewRow();
            DC.HoTen = txtTenKH.Text;
            DC.MaKH = txtMa.Text;
            DC.Loaixe = txtLoaixe.Text;
            DC.Vitri = txtVitri.Text;
            DC.DatCho();
            dsDC.Add(DC);
            hienDSDatCho();
            string path = Application.StartupPath + "\\dsDC.dat";
            bool kt = LuuFIle.LuuFile_DC(dsDC, path);
            if (kt == true)
            {
                MessageBox.Show("Đặt chỗ thành công");
            }
            txtTenKH.Clear();
            txtMa.Clear();
            txtLoaixe.Clear();
            txtVitri.Clear();
        }
        private void ThanhToan()
        {

            if (DuLieuDongDuocChon != null)
            {
                ttdc.LayXe();
                TimeSpan tgGiua = ttdc.TGLayXe - ttdc.TGDatCho;
                double soGio = tgGiua.TotalMinutes;
                string tb = $"Thời gian gửi xe của bạn là: {tgGiua.Hours} giờ {tgGiua.Minutes} phút";
                MessageBox.Show(tb);
                DialogResult result;
                if (soGio < 360)
                {
                    result = MessageBox.Show($"Bạn có chắc chắn muốn thanh toán {20000} VND?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
                else
                    result = MessageBox.Show($"Bạn có chắc chắn muốn thanh toán {100000} VND?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    DuLieuDongDuocChon.ThanhToan();
                    MessageBox.Show("Thanh toán thành công", "Thông báo");
                    dsDC.Remove(DuLieuDongDuocChon);
                    hienDSDatCho();
                    string path = Application.StartupPath + "\\dsDC.dat";
                    bool kt = LuuFIle.LuuFile_DC(dsDC, path);
                    //DongDuocChonThayDoi?.Invoke(null);
                    //ThanhToanHoanTat?.Invoke();
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

        private void dgvDatCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDatCho.Rows[e.RowIndex];
                DuLieuDongDuocChon = (CDATCHO)selectedRow.DataBoundItem;
            }
        }
    }
}
