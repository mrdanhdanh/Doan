using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Entities;
using Newtonsoft.Json;

namespace DAL
{
    internal class LoaiHangLT
    {
        public string MaLoaiHang;
        public string TenLoaiHang;
    }
    public class LuuTruLoaiHang : ILuuTruLoaiHang
    {
        public List<Loaihang> DocDSLH()
        {
            StreamReader reader = new StreamReader("wwwroot/data/loaihang.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<Loaihang> danhsachLoaiHang = JsonConvert.DeserializeObject<List<Loaihang>>(jsonString);
            return danhsachLoaiHang;
        }
        public void LuuDSLH(List<Loaihang> danhsachLoaiHang)
        {
            StreamWriter writer = new StreamWriter("wwwroot/data/loaihang.json");
            string jsonString = JsonConvert.SerializeObject(danhsachLoaiHang);
            writer.Write(jsonString);
            writer.Close();
        }

        public void LuuLoaiHang(Loaihang l)
        {
            List<Loaihang> danhsachLoaiHang = DocDSLH();
            danhsachLoaiHang.Add(l);
            LuuDSLH(danhsachLoaiHang);
        }

        public List<Loaihang> TimKiem(string keyword)
        {
            List<Loaihang> DSLHfull = DocDSLH();
            List<Loaihang> DSLH = new List<Loaihang>();
            foreach (Loaihang l in DSLHfull)
            {
                if (l.MaLoaiHang.Contains(keyword) || l.TenLoaiHang.Contains(keyword))
                {
                    DSLH.Add(l);
                }
            }
            return DSLH;
        }
    }
}
