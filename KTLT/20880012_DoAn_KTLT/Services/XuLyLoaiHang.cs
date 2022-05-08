using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.DAL;

namespace _20880012_DoAn_KTLT.Services
{
    public class XuLyLoaiHang
    {
        public static bool TaoLoaiHang(Loaihang l)
        {
            if (string.IsNullOrWhiteSpace(l.MaLoaiHang) || string.IsNullOrWhiteSpace(l.TenLoaiHang))
            {
                return false;
            } else
            {
                bool kt = false;
                List<Loaihang> DSLH = LuuTruLoaiHang.DocDSLH();
                for (int i=0; i<DSLH.Count(); i++)
                {
                    if (DSLH[i].MaLoaiHang == l.MaLoaiHang || DSLH[i].TenLoaiHang == l.TenLoaiHang)
                    {
                        kt = true;
                        break;
                    }
                }
                if (kt)
                {
                    return false;
                } else
                {
                    return LuuTruLoaiHang.LuuLoaiHang(l);
                }
            }
        }

        public static List<Loaihang> TimKiemLoaiHang(string keyword)
        {
            if (keyword == null)
            {
                keyword = string.Empty;
            }
            List<Loaihang> kq = new List<Loaihang>();
            List<Loaihang> DSLHfull = LuuTruLoaiHang.DocDSLH();
            foreach (Loaihang l in DSLHfull)
            {
                if (l.MaLoaiHang.IndexOf(keyword) != -1 || l.TenLoaiHang.IndexOf(keyword) != -1)
                {
                    kq.Add(l);
                }
            }
            return kq;
        }

        public static bool TimID(string id)
        {
            if (id == null)
            {
                return false;
            }
            else
            {
                List<Loaihang> DSLHfull = LuuTruLoaiHang.DocDSLH();
                foreach (Loaihang l in DSLHfull)
                {
                    if (l.MaLoaiHang == id)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool KiemTraTonTaiMH(string tenLH)
        {
            List<Mathang> DSMHfull = LuuTruMatHang.DocDSMH();
            foreach (Mathang m in DSMHfull)
            {
                if (m.LoaiHang == tenLH)
                {
                    return true;
                }
            }
            return false;
        }
        public static void XoaMHkhiXoaLH(string lh)
        {
            List<Mathang> DSMH = LuuTruMatHang.DocDSMH();
            foreach (Mathang m in DSMH)
            {
                if (m.LoaiHang == lh)
                {
                    XuLyMatHang.XoaMatHang(m.MaMatHang);
                }
            }
        }
        public static string XoaLoaiHang(string id)
        {
            List<Loaihang> DSLH = LuuTruLoaiHang.DocDSLH();
            for (int i=0; i<DSLH.Count(); i++)
            {
                if (DSLH[i].MaLoaiHang == id) 
                {
                    XoaMHkhiXoaLH(DSLH[i].TenLoaiHang);
                    DSLH.RemoveAt(i);
                    LuuTruLoaiHang.LuuDSLH(DSLH);
                    return "Xóa loại hàng thành công";
                }
            }
            return "Không tìm thấy mã loại hàng, xóa thất bại";
        }

        public static Loaihang LayTTLoaiHang(string id)
        {
            Loaihang LH = new Loaihang();
            List<Loaihang> DSLH = LuuTruLoaiHang.DocDSLH();
            foreach (Loaihang l in DSLH)
            {
                if (l.MaLoaiHang == id)
                {
                    LH = l;
                }
            }
            return LH;
        }
        public static bool SuaLoaiHang(string id, string MaLH, string TenLH)
        {
            List<Loaihang> DSLH = LuuTruLoaiHang.DocDSLH();
            for (int i = 0; i < DSLH.Count(); i++)
            {
                if (DSLH[i].MaLoaiHang == id)
                {
                    for (int j=0; j < DSLH.Count(); j++)
                    {
                        if (i != j && (DSLH[j].MaLoaiHang == MaLH || DSLH[j].TenLoaiHang == TenLH))
                        {
                            return false;
                        }
                    }
                    XuLyMatHang.SuaLoaiHangMH(DSLH[i].TenLoaiHang, TenLH);
                    Loaihang l = new Loaihang();
                    l.MaLoaiHang = MaLH;
                    l.TenLoaiHang = TenLH;
                    DSLH[i] = l;
                    LuuTruLoaiHang.LuuDSLH(DSLH);
                    return true;
                }
            }
            return false;
        }
    }
}
