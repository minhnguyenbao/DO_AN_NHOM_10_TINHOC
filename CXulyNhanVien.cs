using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class CXulyNhanVien
    {

        private Dictionary<string, CNhanVien> dsNV;
        public CXulyNhanVien()
        {
            dsNV = new Dictionary<string, CNhanVien>();
        }
        public List<CNhanVien> layDSNhanVien()
        {
            return dsNV.Values.ToList();
        }
        public void them(CNhanVien nv)
        {
            dsNV.Add(nv.MaNV, nv);
        }
        public CNhanVien tim(string ma)
        {
            try
            {
                return dsNV[ma];
            }
            catch
            {
                return null;
            }
        }
        public void xoa(string ma)
        {
            dsNV.Remove(ma);
        }
        public void sua(CNhanVien nv)
        {
            dsNV.Remove(nv.MaNV);
            dsNV.Add(nv.MaNV, nv);
        }
        
        public bool ghiFile(string tenfile)
        {
            using (Stream file = File.Open(tenfile, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, dsNV);
                return true;
            }
        }
        public bool docFile(string tenfile)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            if (File.Exists(tenfile))
            {
                using (FileStream readerFileStream = new FileStream(tenfile, FileMode.Open, System.IO.FileAccess.Read))
                {
                    //dsNV = (Dictionary<string, CNhanVien>)binFormatter.Deserialize(readerFileStream);
                    return true;

                }
            }
            return false;
        }
    }
}
