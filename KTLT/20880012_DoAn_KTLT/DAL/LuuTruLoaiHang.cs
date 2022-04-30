using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using System.IO;
using Newtonsoft.Json;

namespace _20880012_DoAn_KTLT.DAL
{
    public class LuuTruLoaiHang
    {
        public static List<Loaihang> DocDSLH()
        {
            StreamReader reader = new StreamReader("wwwroot/data/loaihang.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<Loaihang> danhsachLoaiHang = JsonConvert.DeserializeObject<List<Loaihang>>(jsonString);
            return danhsachLoaiHang;
        }
        public static bool LuuDSLH(List<Loaihang> danhsachLoaiHang)
        {
            StreamWriter writer = new StreamWriter("wwwroot/data/loaihang.json");
            string jsonString = JsonConvert.SerializeObject(danhsachLoaiHang);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static bool LuuLoaiHang(Loaihang l)
        {
            List<Loaihang> danhsachLoaiHang = DocDSLH();
            if (danhsachLoaiHang[0].MaLoaiHang == null)
            {
                danhsachLoaiHang[0] = l;
            } else
            {
                danhsachLoaiHang.Add(l);
            }
            LuuDSLH(danhsachLoaiHang);
            return true;
        }
    }
}
