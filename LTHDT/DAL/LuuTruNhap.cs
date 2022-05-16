using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class LuuTruNhap : LuuTruHoaDon, ILuuTruHoaDon
    {
        public List<Hoadon> DocDSHD()
        {
            try
            {
                StreamReader reader = new StreamReader("wwwroot/data/hdnhap.json");
                string jsonString = reader.ReadToEnd();
                reader.Close();
                List<HDnhap> DSnhap = JsonConvert.DeserializeObject<List<HDnhap>>(jsonString);
                List<Hoadon> DSHD = new List<Hoadon>();
                foreach (HDnhap hd in DSnhap)
                {
                    DSHD.Add(hd);
                }
                return DSHD;
            }
            catch
            {
                throw new Exception("File dữ liệu Hóa Đơn Nhập không tồn tại");
            }

        }
        public void LuuDSHD(List<Hoadon> danhsachHoadon)
        {
            StreamWriter writer = new StreamWriter("wwwroot/data/hdnhap.json");
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
            for (int i=0; i<DSHD.Count; i++)
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
