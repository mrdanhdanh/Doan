using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using System.IO;
using Newtonsoft.Json;

namespace _20880012_DoAn_KTLT.DAL
{
    public class LuuTruMatHang
    {
        public static List<Mathang> DocDSMH()
        {
            StreamReader reader = new StreamReader("wwwroot\\data\\mathang.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<Mathang> danhsachMatHang = JsonConvert.DeserializeObject<List<Mathang>>(jsonString);
            return danhsachMatHang;
        }
        public static bool LuuDSMH(List<Mathang> danhsachMatHang)
        {
            StreamWriter writer = new StreamWriter("wwwroot\\data\\mathang.json");
            string jsonString = JsonConvert.SerializeObject(danhsachMatHang);
            writer.Write(jsonString);
            writer.Close();

            return true;
        }

        public static bool LuuMatHang(Mathang m)
        {
            List<Mathang> danhsachMatHang = DocDSMH();
            if (danhsachMatHang[0].MaMatHang == null)
            {
                danhsachMatHang[0] = m;
            } else
            {
                danhsachMatHang.Add(m);
            }
            LuuDSMH(danhsachMatHang);
            return true;
        }
    }
}
