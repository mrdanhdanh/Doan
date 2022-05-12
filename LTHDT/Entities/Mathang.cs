
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Mathang
    {
        public string MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public string CongTySanXuat { get; set; }
        public string TenLoaiHang { get; set; }
        public int Gia { get; set; }
        public string NgaySanXuat { get; set; }
        public string HanSuDung { get; set; }

        public Mathang() { }
        public Mathang(string mamh, string tenmh, string ctysx, string tenlh,int gia, string ngaysx, string hansd)
        {
            if (mamh != null && tenmh != null && ctysx != null && tenlh !=null && gia >= 0 && ngaysx != null && hansd != null)
            {
                MaMatHang = mamh;
                TenMatHang = tenmh;
                CongTySanXuat = ctysx;
                TenLoaiHang = tenlh;
                Gia = gia;
                NgaySanXuat = ngaysx;
                HanSuDung = hansd;
            } else
            {
                throw new Exception("Dữ liệu lỗi, vui lòng nhập lại");
            }
        }

        protected bool KiemTraTrung(Mathang m)
        {
            if (this.MaMatHang == m.MaMatHang)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
