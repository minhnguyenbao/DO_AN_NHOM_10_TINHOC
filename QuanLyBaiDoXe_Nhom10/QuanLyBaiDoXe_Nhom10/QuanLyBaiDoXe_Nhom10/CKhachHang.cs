using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiDoXe_Nhom10
{
    [Serializable]
    public class CKhachHang
    {
        private string m_makh, m_tenkh, m_diachi, m_sdt, m_cccd, m_loaixe, m_phuongthuc;
        private DateTime m_ngaysinh;
        private string m_gioitinh;
        public string MaKH
        {
            get { return m_makh; }
            set { m_makh = value; }
        }
        public string LoaiXe
        {
            get { return m_loaixe; }
            set { m_loaixe = value; }
        }
        public string PhuongThuc
        {
            get { return m_phuongthuc; }
            set { m_phuongthuc = value; }
        }
        public string TenKH
        {
            get { return m_tenkh; }
            set { m_tenkh = value; }
        }
        public string DiaChi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }
        public string SDT
        {
            get { return m_sdt; }
            set { m_sdt = value; }
        }
        public string CCCD
        {
            get { return m_cccd; }
            set { m_cccd = value; }
        }
        public DateTime NgaySinh
        {
            get { return m_ngaysinh; }
            set { m_ngaysinh = value; }
        }
        public string GioiTinh
        {
            get { return m_gioitinh; }
            set { m_gioitinh = value; }
        }
        public CKhachHang()
        {
            m_makh = "";
            m_loaixe = "";
            m_phuongthuc = "";
            m_tenkh = "";
            m_ngaysinh = DateTime.Now;
            m_gioitinh = "";
            m_cccd = "";
            m_sdt = "";
            m_diachi = "";
        }
        public CKhachHang(string makh, string tenkh, string diachi, string sdt, string cccd, DateTime ngaysinh, string gioitinh, string loaixe, string pt)
        {
            m_makh = makh;
            m_loaixe = loaixe;
            m_phuongthuc = pt;
            m_tenkh = tenkh;
            m_diachi = diachi;
            m_sdt = sdt;
            m_cccd = cccd;
            m_ngaysinh = ngaysinh;
            m_gioitinh = gioitinh;

        }
    }
}
