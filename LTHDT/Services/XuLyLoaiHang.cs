using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Services;
using DAL;


namespace Services
{
    public class XuLyLoaiHang : IXuLyLoaiHang
    {
        private ILuuTruLoaiHang luutru;
        private IXuLyMatHang xulyMH;
        public XuLyLoaiHang()
        {
            luutru = new LuuTruLoaiHang();
            xulyMH = new XuLyMatHang();
        }
        public ServiceResult<bool> ThemLoaiHang(Loaihang l)
        {
            if (KiemTraTrungDL(l))
            {
                return new ServiceResult<bool>(false, false, "Trùng dữ liệu, không thể thêm");
            }
            else
            {
                luutru.LuuLoaiHang(l);
                return new ServiceResult<bool>(true, true, "Thêm thành công");
            }
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
            if (keyword == null)
            {
                keyword = String.Empty;
            }
            return luutru.TimKiem(keyword);
        }
        
        public ServiceResult<Loaihang> DocLoaiHang(string id)
        {
            if (id == null)
            {
                throw new Exception("Lỗi dữ liệu, vui lòng thử lại");
            } else
            {
                Loaihang l = luutru.TimKiemID(id);
                if (l == null)
                {
                    return new ServiceResult<Loaihang>(false, null, "Không tìm thấy loại hàng");
                }
                else
                {
                    return new ServiceResult<Loaihang>(true, l, null);
                }
            }
        }
        public ServiceResult<bool> XoaLoaiHang(string id)
        {
            if (id == null)
            {
                throw new Exception("Lỗi dữ liệu, vui lòng thử lại");
            }
            else
            {
                Loaihang lold = DocLoaiHang(id).Data;
                var kq = luutru.XoaID(id);
                if (kq)
                {
                    xulyMH.XoaMHkhiXoaLH(lold.TenLoaiHang);
                    return new ServiceResult<bool>(true, true, "Xóa thành công");
                } else
                {
                    return new ServiceResult<bool>(false, false, "Không tìm thấy loại hàng, không thể xóa");
                }
            }
        }
        public ServiceResult<Loaihang> SuaLoaiHang(string id, Loaihang l)
        {
            if (id == null)
            {
                throw new Exception("Lỗi dữ liệu, vui lòng thử lại");
            }
            else
            {
                Loaihang lold = DocLoaiHang(id).Data;
                bool kq = luutru.SuaLH(id, l);
                if (kq)
                {
                    xulyMH.SuaMHkhiSuaLH(lold.TenLoaiHang, l.TenLoaiHang);
                    return new ServiceResult<Loaihang>(true, l, "Sửa thành công");
                } else
                {
                    return new ServiceResult<Loaihang>(true, l, "Không thể sửa do trùng dữ liệu");
                }
            }
        }
    }
}
