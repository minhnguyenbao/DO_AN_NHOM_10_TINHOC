using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CNhanVien
    {
        private string m_manv, m_tennv, m_diachi, m_sdt, m_cccd;
        private DateTime m_ngaysinh;
        private bool m_gioitinh;
        public string MaNV
        {
            get { return m_manv; }
            set { m_manv = value; }
        }
        public string TenNV
        {
            get { return m_tennv; }
            set { m_tennv = value; }
        }
        public string DiaChi
        {
            get { return m_diachi;}
            set { m_diachi = value;}
        }
        public string SDT
        {
            get { return m_sdt;}
            set { m_sdt = value;}
        }
        public string CCCD
        {
            get { return m_cccd;}
            set { m_cccd = value;}
        }
        public DateTime NgaySinh
        {
            get { return m_ngaysinh; }
            set { m_ngaysinh = value; }
        }
        public bool GioiTinh
        {
            get { return m_gioitinh;}
            set { m_gioitinh = value;}
        }
        public CNhanVien()
        {
            m_manv = "";
            m_tennv = "";
            m_ngaysinh=DateTime.Now;
            m_gioitinh = true;
            m_cccd = "";
            m_sdt = "";
            m_diachi = "";
        }
        public CNhanVien(string manv, string tennv, string diachi, string sdt, string cccd, DateTime ngaysinh, bool gioitinh)
        {
            m_manv = manv;
            m_tennv = tennv;
            m_diachi = diachi;
            m_sdt = sdt;
            m_cccd = cccd;
            m_ngaysinh = ngaysinh;
            m_gioitinh = gioitinh;
           
        }
    }
}
