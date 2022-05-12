using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Entities;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruLoaiHang : ILuuTruLoaiHang
    {
        public List<Loaihang> DocDSLH()
        {
            try
            {
                StreamReader reader = new StreamReader("wwwroot/data/loaihang.json");
                string jsonString = reader.ReadToEnd();
                reader.Close();
                List<Loaihang> danhsachLoaiHang = JsonConvert.DeserializeObject<List<Loaihang>>(jsonString);
                return danhsachLoaiHang;
            }
            catch
            {
                throw new Exception("File dữ liệu không tồn tại");
            }
            
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
            if (danhsachLoaiHang[0].MaLoaiHang == null)
            {
                danhsachLoaiHang[0] = l;
            } else
            {
                danhsachLoaiHang.Add(l);
            }
            LuuDSLH(danhsachLoaiHang);
        }

        public List<Loaihang> TimKiem(string keyword)
        {
            List<Loaihang> DSLHfull = DocDSLH();
            if (DSLHfull[0].MaLoaiHang == null)
            {
                throw new Exception("File dữ liệu rỗng, không thể tải");
            } else
            {
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
        public Loaihang TimKiemID(string id)
        {
            List<Loaihang> DSLHfull = DocDSLH();
            foreach (Loaihang l in DSLHfull)
            {
                if (l.MaLoaiHang == id)
                {
                    return l;
                }
            }
            return null;
        }
        public bool XoaID(string id)
        {
            List<Loaihang> DSLHfull = DocDSLH();
            for (int i=0; i<DSLHfull.Count; i++)
            {
                if (DSLHfull[i].MaLoaiHang == id)
                {
                    DSLHfull.RemoveAt(i);
                    LuuDSLH(DSLHfull);
                    return true;
                }
            }
            return false;
        }
        public bool SuaLH(string id, Loaihang l)
        {
            List<Loaihang> DSLHfull = DocDSLH();
            for (int i = 0; i < DSLHfull.Count; i++)
            {
                if (DSLHfull[i].MaLoaiHang == id)
                {
                    foreach (Loaihang lh in DSLHfull)
                    {
                        if (lh.KiemTraTrung(l) && id != lh.MaLoaiHang)
                        {
                            return false;
                        }
                    }
                    DSLHfull[i] = l;
                    LuuDSLH(DSLHfull);
                    return true;
                }
            }
            throw new Exception("Lỗi dữ liệu, không thể sửa");
        }
    }
}
