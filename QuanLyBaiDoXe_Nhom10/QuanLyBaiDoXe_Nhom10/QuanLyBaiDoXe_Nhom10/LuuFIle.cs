using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiDoXe_Nhom10
{
    public class LuuFIle
    {
        public static bool LuuFile(List<CKhachHang> dsKh, string path)
        {
           

            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsKh);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<CKhachHang> DocFile(string path)
        {

            List<CKhachHang> dsKh = new List<CKhachHang>();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object data = bf.Deserialize(fs);
            dsKh = data as List<CKhachHang>;
            fs.Close();
            return dsKh;
        }
        public static bool LuuFile_DC(List<CDATCHO> dsDC, string path)
        {


            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsDC);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<CDATCHO> DocFile_DC(string path)
        {

            List<CDATCHO> dsDC = new List<CDATCHO>();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object data = bf.Deserialize(fs);
            dsDC = data as List<CDATCHO>;
            fs.Close();
            return dsDC;
        }
    }
}
