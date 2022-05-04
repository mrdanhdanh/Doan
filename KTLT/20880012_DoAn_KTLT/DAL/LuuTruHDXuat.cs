using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using System.IO;
using Newtonsoft.Json;

namespace _20880012_DoAn_KTLT.DAL
{
    public class LuuTruHDXuat
    {
        public static List<HDxuat> DocHDXuat()
        {
            StreamReader reader = new StreamReader("wwwroot/data/hdxuat.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<HDxuat> danhsachHD = JsonConvert.DeserializeObject<List<HDxuat>>(jsonString);
            return danhsachHD;
        }
        public static bool LuuDSXuat(List<HDxuat> danhsachHD)
        {
            StreamWriter writer = new StreamWriter("wwwroot/data/hdxuat.json");
            string jsonString = JsonConvert.SerializeObject(danhsachHD);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static bool LuuHDXuat(HDxuat x)
        {
            List<HDxuat> danhsachHD = DocHDXuat();
            if (danhsachHD[0].MaHD == null)
            {
                danhsachHD[0] = x;
            }
            else
            {
                danhsachHD.Add(x);
            }
            LuuDSXuat(danhsachHD);
            return true;
        }
    }
}
