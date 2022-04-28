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
        public static bool KiemTraTrung(List<Tonkho> DSton, string mamh)
        {
            foreach (Tonkho t in DSton)
            {
                if (t.MaMH == mamh)
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Tonkho> TaiDSTonKho(string mamh)
        {
            List<HDnhap> DSnhap = LuuTruHDNhap.DocHDNhap();
            List<HDxuat> DSxuat = LuuTruHDXuat.DocHDXuat();
            List<Tonkho> DSton = new List<Tonkho>();
            if (mamh == null)
            {
                mamh = string.Empty;
            }
            foreach (HDnhap hdn in DSnhap)
            {
                if (hdn.MaMH.IndexOf(mamh) != -1 && KiemTraTrung(DSton, hdn.MaMH) == false)
                {
                    Tonkho t = new Tonkho();
                    t.MaMH = hdn.MaMH;
                    foreach (HDnhap hdnsl in DSnhap)
                    {
                        if (hdnsl.MaMH == t.MaMH)
                        {
                            t.SL += hdnsl.SoLuong;
                        }
                    }
                    foreach (HDxuat hdxsl in DSxuat)
                    {
                        if (hdxsl.MaMH == t.MaMH)
                        {
                            t.SL -= hdxsl.SoLuong;
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
