using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Entities;
using DAL;

namespace Services
{
    public class XuLyMatHang : IXuLyMatHang
    {
        public ILuuTruMatHang luutru;
        public IXuLyHoaDon xulyN;
        public IXuLyHoaDon xulyX;
        public XuLyMatHang()
        {
            luutru = new LuuTruMatHang();
            xulyN = new XuLyNhap();
            xulyX = new XuLyXuat();
        }
        public ServiceResult<List<Mathang>> TimKiemMatHang(string keyword)
        {
            List<Mathang> DSMH = luutru.TimKiem(keyword);
            if (DSMH.Count == 0)
            {
                return new ServiceResult<List<Mathang>>(false, null, "Không tìm thấy mặt hàng");
            } else
            {
                return new ServiceResult<List<Mathang>>(true, DSMH, null);
            }
            
        }
        public ServiceResult<Mathang> DocMatHang(string id)
        {
            Mathang m = luutru.DocID(id);
            if (m == null)
            {
                return new ServiceResult<Mathang>(false, null, "Không tìm thấy mặt hàng");
            } else
            {
                return new ServiceResult<Mathang>(true, luutru.DocID(id), null);
            }
        }

        public string XoaMatHang(string id)
        {
            if (luutru.XoaID(id))
            {
                xulyN.SuaHDkhiSuaMH(id, "deleted");
                xulyX.SuaHDkhiSuaMH(id, "deleted");
                return "Xóa thành công";

            } else
            {
                return "Không tìm thấy mặt hàng, xóa thất bại";
            }
        }
        public string ThemMatHang(Mathang m)
        {
            List<Mathang> DSMH = luutru.DocDSMH();
            foreach (Mathang mh in DSMH)
            {
                if (mh.KiemTraTrung(m))
                {
                    return "Trùng mã mặt hàng, không thể thêm mới";
                }
            }
            luutru.LuuMatHang(m);
            return "Thêm mặt hàng thành công";
        }
        public string SuaMatHang(string id, Mathang m)
        {
            
            List<Mathang> DSMH = luutru.DocDSMH();
            if (id != m.MaMatHang)
            {
                foreach (Mathang mh in DSMH)
                {
                    if (mh.KiemTraTrung(m))
                    {
                        return "Mã mặt hàng trùng, không thể sửa";
                    }
                }
            }
            for (int i=0; i<DSMH.Count; i++)
            {
                if (DSMH[i].MaMatHang == id)
                {
                    DSMH[i] = m;
                    if (id != m.MaMatHang)
                    {
                        xulyN.SuaHDkhiSuaMH(id, m.MaMatHang);
                        xulyX.SuaHDkhiSuaMH(id, m.MaMatHang);
                    }
                    luutru.LuuDSMH(DSMH);
                    return "Sửa thành công";
                }
            }
            throw new Exception("Không tìm thấy mặt hàng, không thể sửa");
        }
        public void SuaMHkhiSuaLH(string lold, string lnew)
        {
            List<Mathang> DSMH = luutru.DocDSMH();
            foreach (Mathang m in DSMH)
            {
                if (m.TenLoaiHang == lold)
                {
                    m.TenLoaiHang = lnew;
                }
            }
            luutru.LuuDSMH(DSMH);
        }
        public void XoaMHkhiXoaLH(string tenlh)
        {
            List<Mathang> DSMH = luutru.DocDSMH();
            int index = 0;

            while (index != -1)
            {
                index = DSMH.FindIndex(m => m.TenLoaiHang == tenlh);
                if (index != -1)
                {
                    DSMH.RemoveAt(index);
                }
            }
            luutru.LuuDSMH(DSMH);
        }
    }
}