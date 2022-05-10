using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DAL;


namespace Services
{
    public class XuLyLoaiHang : IXuLyLoaiHang
    {
        public ILuuTruLoaiHang luutru;

        public XuLyLoaiHang()
        {
            luutru = new LuuTruLoaiHang();
        }
        public ServiceResult<bool> ThemLoaiHang(Loaihang l)
        {
            luutru.LuuLoaiHang(l);
            return new ServiceResult<bool>(true, true, "Thêm thành công");
            //if (KiemTraTrungDL(l))
            //{
            //    return new ServiceResult<bool>(false, false, "Trùng dữ liệu, không thể thêm");
            //} else
            //{
            //    return new ServiceResult<bool>(true, true, "Thêm thành công");
            //}
        }
        protected bool KiemTraTrungDL(Loaihang l)
        {
            List<Loaihang> DSLH = luutru.DocDSLH();
            foreach (Loaihang lh in DSLH) {
                if (l.KiemTraTrung(lh))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Loaihang> TimKiemLoaiHang(string keyword)
        {
            //if (keyword == null)
            //{
                return luutru.DocDSLH();
            //}
        }
    }
}
