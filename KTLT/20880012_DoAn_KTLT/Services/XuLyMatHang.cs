using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.DAL;

namespace _20880012_DoAn_KTLT.Services
{
    public class XuLyMatHang
    {
        public static bool TaoMatHang(Mathang m)
        {
            bool kt = false;
            List<Mathang> DSMH = LuuTruMatHang.DocDSMH();
            foreach (Mathang mh in DSMH)
            {
                if (m.MaMatHang == mh.MaMatHang)
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
                LuuTruMatHang.LuuMatHang(m);
                return true;
            }

        }

        public static List<Mathang> TimKiemMatHang(string keyword)
        {
            if (keyword == null)
            {
                keyword = string.Empty;
            }
            List<Mathang> DSMHfull = LuuTruMatHang.DocDSMH();
            List<Mathang> kq = new List<Mathang>();
            foreach (Mathang m in DSMHfull)
            {
                if (m.MaMatHang.IndexOf(keyword) != -1 || m.TenMatHang.IndexOf(keyword) != -1)
                {
                    kq.Add(m);
                }
            }
            return kq;
        }

        public static void SuaLoaiHangMH(string LHold, string LHnew)
        {
            List<Mathang> DSMHfull = LuuTruMatHang.DocDSMH();
            Mathang m = new Mathang();
            for (int i=0; i<DSMHfull.Count(); i++)
            {
                if (DSMHfull[i].LoaiHang == LHold)
                {
                    m = DSMHfull[i];
                    m.LoaiHang = LHnew;
                    DSMHfull[i] = m;
                }
            }
            LuuTruMatHang.LuuDSMH(DSMHfull);
        }

        public static bool TimKiemID(string id)
        {
            List<Mathang> DSMHfull = LuuTruMatHang.DocDSMH();
            foreach (Mathang m in DSMHfull)
            {
                if (m.MaMatHang == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static void DoiMHtrongHD(string oldMH, string newMH)
        {
            List<HDnhap> DSHN = LuuTruHDNhap.DocHDNhap();
            List<HDxuat> DSHX = LuuTruHDXuat.DocHDXuat();
            foreach (HDnhap h in DSHN)
            {
                foreach (PhieuHH hh in h.DSNhapHang)
                {
                    if (hh.MaMH == oldMH)
                    {
                        hh.MaMH = newMH;
                    }
                }
            }
            foreach (HDxuat h in DSHX)
            {
                foreach (PhieuHH hh in h.DSBanHang)
                {
                    if (hh.MaMH == oldMH)
                    {
                        hh.MaMH = newMH;
                    }
                }
            }
            LuuTruHDNhap.LuuDSNhap(DSHN);
            LuuTruHDXuat.LuuDSXuat(DSHX);
        }
        public static bool XoaMatHang(string id)
        {
            List<Mathang> DSMHfull = LuuTruMatHang.DocDSMH();
            for (int i=0; i < DSMHfull.Count(); i++)
            {
                if (DSMHfull[i].MaMatHang == id)
                {
                    DSMHfull.RemoveAt(i);
                    DoiMHtrongHD(id, "deleted");
                    LuuTruMatHang.LuuDSMH(DSMHfull);
                    return true;
                }
            }
            return false;
        }
        public static Mathang LayTTMatHang(string id)
        {
            List<Mathang> DSMHfull = LuuTruMatHang.DocDSMH();
            Mathang mh = new Mathang();
            foreach (Mathang m in DSMHfull)
            {
                if (m.MaMatHang == id)
                {
                    return m;
                }
            }
            return mh;
        }
        
        public static bool SuaMatHang(string id, string MaMH, string TenMH, string CtySX, string TenLH, int Gia, string NgaySX, string HanSD)
        {
            List<Mathang> DSMHfull = LuuTruMatHang.DocDSMH();
            
            for (int i = 0; i < DSMHfull.Count(); i++)
            {
                if (DSMHfull[i].MaMatHang == id)
                {
                    for (int j = 0; j < DSMHfull.Count(); j++)
                    {
                        if (i!= j && DSMHfull[j].MaMatHang == MaMH)
                        {
                            return false;
                        }
                    }
                    Mathang m = new Mathang();
                    m.MaMatHang = MaMH;
                    m.TenMatHang = TenMH;
                    m.CongTySanXuat = CtySX;
                    m.LoaiHang = TenLH;
                    m.Gia = Gia;
                    m.NgaySanXuat = NgaySX;
                    m.HanSuDung = HanSD;
                    DSMHfull[i] = m;
                    LuuTruMatHang.LuuDSMH(DSMHfull);
                    if (id != MaMH) //Nếu mã MH không thay đổi thì không cần đổi thông tin trong các hd Nhập và Xuất
                    {
                        DoiMHtrongHD(id, MaMH);
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
