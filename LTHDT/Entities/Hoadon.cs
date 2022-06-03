using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class PhieuHH
    {
        public string MaMH { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        
        public PhieuHH() { }

        public PhieuHH(string mamh, int gia, int sl)
        {
            MaMH = mamh;
            Gia = gia;
            SoLuong = sl;
        }
        public int TinhTien()
        {
            return this.Gia * this.SoLuong;
        }
    }
    public abstract class Hoadon
    {
        public string MaHD { get; set; }
        public string NgayTao { get; set; }
        public List<PhieuHH> DShanghoa { get; set; }
        public int ThanhTien { get; set; }

        public virtual void TaoHoadon(string mahd, string ngaytao, List<PhieuHH> dshanghoa)
        {
            dshanghoa = KiemtraDSHH(dshanghoa);
            if (mahd == null || ngaytao == null)
            {
                throw new Exception("Dữ liệu phải khác rỗng, vui lòng nhập lại");
            }

            MaHD = mahd;
            NgayTao = ngaytao;
            DShanghoa = dshanghoa;
            ThanhTien = TinhThanhTien(dshanghoa);
        }

        protected List<PhieuHH> KiemtraDSHH(List<PhieuHH> dshh)
        {
            
            List<PhieuHH> DS = new List<PhieuHH>();
            foreach (PhieuHH hh in dshh)
            {
                if(hh.MaMH != "" && hh.SoLuong >0 && hh.Gia>=0)
                {
                    DS.Add(hh);
                }
            }
            if (DS.Count>0)
            {
                return DS;
            } else
            {
                throw new Exception("Lỗi dữ liệu, vui lòng thử lại");
            }
            
        }

        protected int TinhThanhTien(List<PhieuHH> dshh)
        {
            int tongtien = 0;
            foreach (PhieuHH hh in dshh)
            {
                tongtien += hh.TinhTien();
            }
            return tongtien;
        }

        public bool KiemTraTrung(Hoadon h)
        {
            if (this.MaHD == h.MaHD)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public abstract string LoaiHD();
        
    }
   
}
