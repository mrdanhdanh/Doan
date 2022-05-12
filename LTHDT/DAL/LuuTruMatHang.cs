using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruMatHang : ILuuTruMatHang
    {
        public List<Mathang> DocDSMH()
        {
            try
            {
                StreamReader reader = new StreamReader("wwwroot/data/mathang.json");
                string jsonString = reader.ReadToEnd();
                reader.Close();
                List<Mathang> danhsachMatHang = JsonConvert.DeserializeObject<List<Mathang>>(jsonString);
                return danhsachMatHang;
            }
            catch
            {
                throw new Exception("File dữ liệu Mặt Hàng không tồn tại");
            }

        }
        public void LuuDSMH(List<Mathang> danhsachMatHang)
        {
            StreamWriter writer = new StreamWriter("wwwroot/data/mathang.json");
            string jsonString = JsonConvert.SerializeObject(danhsachMatHang);
            writer.Write(jsonString);
            writer.Close();
        }

        public void LuuMatHang(Mathang m)
        {
            List<Mathang> danhsachMatHang = DocDSMH();
            if (danhsachMatHang[0].MaMatHang == null)
            {
                danhsachMatHang[0] = m;
            }
            else
            {
                danhsachMatHang.Add(m);
            }
            LuuDSMH(danhsachMatHang);
        }
        public List<Mathang> TimKiem(string keyword)
        {
            List<Mathang> DSMHfull = DocDSMH();
            if (DSMHfull[0].MaMatHang == null)
            {
                throw new Exception("File dữ liệu Mặt Hàng rỗng, vui lòng thêm mặt hàng");
            }
            else
            {
                if (keyword == null)
                {
                    return DSMHfull;
                }
                else
                {
                    List<Mathang> DSMH = new List<Mathang>();
                    foreach (Mathang m in DSMHfull)
                    {
                        if (m.MaMatHang.Contains(keyword) || m.TenMatHang.Contains(keyword))
                        {
                            DSMH.Add(m);
                        }
                    }
                    return DSMH;
                }
            }
        }
        public Mathang DocID(string id)
        {
            List<Mathang> DSMHfull = DocDSMH();
            if (DSMHfull[0].MaMatHang == null)
            {
                throw new Exception("File dữ liệu Mặt Hàng rỗng, vui lòng thêm mặt hàng");
            }
            else
            {
                if (id == null)
                {
                    throw new Exception("Lỗi dữ liệu, vui lòng thử lại");
                }
                else
                {
                    foreach (Mathang m in DSMHfull)
                    {
                        if (m.MaMatHang == id)
                        {
                            return m;
                        }
                    }
                    return null;
                }
            }
        }
        public bool XoaID(string id)
        {
            List<Mathang> DSMHfull = DocDSMH();
            if (DSMHfull[0].MaMatHang == null)
            {
                throw new Exception("File dữ liệu Mặt Hàng rỗng, vui lòng thêm mặt hàng");
            }
            else
            {
                if (id == null)
                {
                    throw new Exception("Lỗi dữ liệu, vui lòng thử lại");
                }
                else
                {
                    for (int i=0; i<DSMHfull.Count; i++)
                    {
                        if (DSMHfull[i].MaMatHang == id)
                        {
                            DSMHfull.RemoveAt(i);
                            LuuDSMH(DSMHfull);
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }
}
