using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Loaihang
    {
        public string MaLoaiHang;
        public string TenLoaiHang;
        public string DocMaLH()
        {
            return this.MaLoaiHang;
        }
        public string DocTenLH()
        {
            return this.TenLoaiHang;
        }
        public Loaihang() { }
        public Loaihang(string malh, string tenlh)
        {
            if (KiemTraDuLieu(malh, tenlh))
            {
                MaLoaiHang = malh;
                TenLoaiHang = tenlh;
            } else
            {
                throw new Exception("Dữ liệu không hợp lệ");
            }

        }

        protected bool KiemTraDuLieu(string malh, string tenlh)
        {
            if (malh == null || tenlh == null)
            {
                return false;
            } else
            {
                return true;
            }
        }
        public bool KiemTraTrung(Loaihang l)
        {
            if (this.MaLoaiHang == l.MaLoaiHang || this.TenLoaiHang == l.TenLoaiHang)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
