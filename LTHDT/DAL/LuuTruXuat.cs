using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruXuat : LuuTruHoaDon, ILuuTruHoaDon
    {
        public List<Hoadon> DocDSHD()
        {
            try
            {
                StreamReader reader = new StreamReader("wwwroot/data/hdxuat.json");
                string jsonString = reader.ReadToEnd();
                reader.Close();
                List<HDxuat> DSxuat = JsonConvert.DeserializeObject<List<HDxuat>>(jsonString);
                List<Hoadon> DSHD = new List<Hoadon>();
                foreach (HDxuat hd in DSxuat)
                {
                    DSHD.Add(hd);
                }
                return DSHD;
            }
            catch
            {
                throw new Exception("File dữ liệu Hóa Đơn Xuất không tồn tại");
            }

        }
        public void LuuDSHD(List<Hoadon> danhsachHoadon)
        {
            StreamWriter writer = new StreamWriter("wwwroot/data/hdxuat.json");
            string jsonString = JsonConvert.SerializeObject(danhsachHoadon);
            writer.Write(jsonString);
            writer.Close();
        }
        public override void LuuHD(Hoadon h)
        {
            List<Hoadon> DSHD = DocDSHD();
            if (DSHD[0].MaHD == null)
            {
                DSHD[0] = h;
            }
            else
            {
                DSHD.Add(h);
            }
            LuuDSHD(DSHD);
        }
        public override bool XoaID(string id)
        {
            List<Hoadon> DSHD = DocDSHD();
            for (int i = 0; i < DSHD.Count; i++)
            {
                if (DSHD[i].MaHD == id)
                {
                    DSHD.RemoveAt(i);
                    LuuDSHD(DSHD);
                    return true;
                }
            }
            return false;
        }
    }
}
