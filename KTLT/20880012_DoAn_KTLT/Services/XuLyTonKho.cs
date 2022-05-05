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
        public static List<TonkhoMH> TaiDSTonKhoMH(string mamh, bool hethan)
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
        public static List<TonkhoLH> TaiDSTonKhoLH(string malh)
        {
            List<TonkhoLH> tklh = new List<TonkhoLH>();
            List<TonkhoMH> tkmh = TaiDSTonKhoMH(null, false);
            List<Mathang> dsmh = XuLyMatHang.TimKiemMatHang(null);
            List<Loaihang> dslh = XuLyLoaiHang.TimKiemLoaiHang(null);

            foreach (Loaihang l in dslh)
            {
                if (malh == null || l.MaLoaiHang == malh) //Neu malh la null => lay tat ca, neu khac null => chi lay đúng mã loại hàng
                {
                    TonkhoLH tlh = new TonkhoLH();
                    tlh.TenLH = l.TenLoaiHang;
                    tlh.SL = 0;
                    foreach (Mathang m in dsmh)
                    {
                        if (m.LoaiHang == tlh.TenLH)
                        {
                            var target = tkmh.FirstOrDefault(t => t.MaMH == m.MaMatHang);
                            if (target != null)
                            {
                                tlh.SL += target.SL;
                            }
                        }
                    }
                    tklh.Add(tlh);
                }
                
            }

            return tklh;
        }
    }
}
