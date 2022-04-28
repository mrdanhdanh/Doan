using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using System.IO;
using Newtonsoft.Json;

namespace _20880012_DoAn_KTLT.DAL
{
    public class LuuTruHDNhap
    {
        public static List<HDnhap> DocHDNhap()
        {
            StreamReader reader = new StreamReader("wwwroot\\data\\hdnhap.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<HDnhap> danhsachHD = JsonConvert.DeserializeObject<List<HDnhap>>(jsonString);
            return danhsachHD;
        }
        public static bool LuuDSNhap(List<HDnhap> danhsachHD)
        {
            StreamWriter writer = new StreamWriter("wwwroot\\data\\hdnhap.json");
            string jsonString = JsonConvert.SerializeObject(danhsachHD);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static bool LuuHDNhap(HDnhap h)
        {
            List<HDnhap> danhsachHD = DocHDNhap();
            if (danhsachHD[0].MaHD == null)
            {
                danhsachHD[0] = h;
            }
            else
            {
                danhsachHD.Add(h);
            }
            LuuDSNhap(danhsachHD);
            return true;
        }
    }
}
