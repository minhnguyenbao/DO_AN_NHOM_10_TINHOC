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
    public partial class ThongTinBaiDo : Form
    {
        public ThongTinBaiDo()
        {
            InitializeComponent();
        }
        public class ThongTinBaiXe
        {
            private string m_tenbaixe, m_diachi, m_gmail, m_sdt;

            public string Tenbaixe
            {
                get { return m_tenbaixe; }
                set { m_tenbaixe = value;}
            }
            public string DiaChi
            {
                get { return m_diachi;}
                set { m_diachi = value;}
            }
            public string Gmail
            {
                get { return m_gmail; }
                set { m_gmail = value;}
            }
            public string Sdt
            {
                get { return m_sdt; }
                set { m_sdt = value;}
            }
            public ThongTinBaiXe()
            {
                m_tenbaixe = "";
                m_diachi = "";
                m_gmail = "";
                m_sdt = "";

            }
            public ThongTinBaiXe(string tenbaixe,string diachi,string gmail,string sdt)
            {
                Tenbaixe = tenbaixe;
                DiaChi = diachi;
                Gmail = gmail;
                Sdt = sdt;
            }

        }
        

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
