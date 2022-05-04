using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.DAL;

namespace _20880012_DoAn_KTLT.Services
{
    public class XuLyTonKho
    {
        public static List<TonkhoMH> TaiDSTonKhoMH(string mamh)
        {
            List<HDnhap> DSnhap = LuuTruHDNhap.DocHDNhap();
            List<HDxuat> DSxuat = LuuTruHDXuat.DocHDXuat();
            List<Mathang> DSMH = XuLyMatHang.TimKiemMatHang(null);
            List<TonkhoMH> DSton = new List<TonkhoMH>();
            if (mamh == null)
            {
                mamh = String.Empty;
            }
            foreach (Mathang m in DSMH)
            {
                if (m.MaMatHang.IndexOf(mamh) != -1) //Nếu chuỗi rỗng -> lấy tất cả mamh, nếu có giá trị -> chỉ tìm đúng mamh
                {
                    TonkhoMH t = new TonkhoMH();
                    t.MaMH = m.MaMatHang;
                    foreach (HDnhap h in DSnhap)
                    {
                        foreach (PhieuHH hh in h.DSNhapHang)
                        {
                            if (hh.MaMH == t.MaMH)
                            {
                                t.SL += hh.SoLuong;
                            }
                        }
                    }
                    foreach (HDxuat h in DSxuat)
                    {
                        foreach (PhieuHH hh in h.DSBanHang)
                        {
                            if (hh.MaMH == t.MaMH)
                            {
                                t.SL -= hh.SoLuong;
                            }
                        }
                    }
                    if (t.SL > 0)
                    {
                        DSton.Add(t);
                    }
                }
            }

            return DSton;
        }
    }
}
