using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiDoXe_Nhom10
{
    [Serializable]
    public class CDATCHO
    {
        private string m_hoten;
        private string m_loaixe;
        private string m_ma;
        private string m_vitri;
        private DateTime m_tgDatCho;
        private DateTime m_tgLayXe;

        public string Vitri
        {
            get { return m_vitri; }
            set { m_vitri = value; }

        }
        public string HoTen
        {
            get { return m_hoten; }
            set { m_hoten = value; }

        }

        public DateTime TGDatCho
        {
            get { return m_tgDatCho; }
            set { m_tgDatCho = value; }
        }
        public DateTime TGLayXe { get; set; }

        public string MaKH
        {
            get { return m_ma; }
            set { m_ma = value; }
        }
        public string Loaixe
        {
            get { return m_loaixe; }
            set { m_loaixe = value; }
        }


        public CDATCHO()
        {
            m_ma = "";
            m_hoten = "";
            m_loaixe = "";
            m_vitri = "";
            m_tgDatCho = DateTime.Now;
            m_tgLayXe = DateTime.Now;
        }
        public CDATCHO(string vitri, string hoten, string ma, string loaixe, DateTime tgdc)
        {
            m_loaixe = loaixe;
            m_hoten = hoten;
            m_ma = ma;
            m_vitri = vitri;
            m_tgDatCho = tgdc;
        }
        public void DatCho()
        {
            TGDatCho = DateTime.Now;
        }
        public void LayXe()
        {
            TGLayXe = DateTime.Now;
        }

        public void ThanhToan()
        {
            Console.WriteLine($"Thông tin đặt chỗ:\nHọ và tên: {m_hoten}\nMã KH: {m_ma}\nLoại xe: {m_loaixe}");
            InHoaDon();
            LuuThongTinThanhToan();
        }

        private void InHoaDon()
        {
            Console.WriteLine("Hóa đơn đã được in.");
        }

        private void LuuThongTinThanhToan()
        {
            Console.WriteLine("Thông tin thanh toán đã được lưu vào cơ sở dữ liệu.");
        }
    }
}
