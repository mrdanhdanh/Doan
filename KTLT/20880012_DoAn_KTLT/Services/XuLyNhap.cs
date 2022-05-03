using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.DAL;

namespace _20880012_DoAn_KTLT.Services
{
    public class XuLyNhap
    {
        public static string NhapHD(HDnhap h)
        {
            //Kiem tra trung ma hoa don
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            foreach (HDnhap hd in DSHD)
            {
                if (hd.MaHD == h.MaHD)
                {
                    return "Trung ma hoa don, nhap that bai";
                }
            }
            //kiem tra hang hoa loi du lieu
            List<PhieuHH> HHdakiem = new List<PhieuHH>();
            foreach (PhieuHH hh in h.DSNhapHang)
            {
                if (hh.MaMH!=null && hh.Gia!=0 && hh.SoLuong!=0)
                {
                    HHdakiem.Add(hh);
                }
            }
            if (HHdakiem.Count() == 0)
            {
                return "Du lieu sai, vui long nhap lai";    
            } else
            {
                h.DSNhapHang = HHdakiem;
                //Buoc 3: Luu 
                LuuTruHDNhap.LuuHDNhap(h);
                return "Tao thanh cong hoa don Nhap voi "+ HHdakiem.Count() + " mat hang";

            }
            
        }
        public static List<HDnhap> TimKiemHD(string keyword, string keydate)
        {
            if (keyword == null)
            {
                keyword = string.Empty;
            }
            if (keydate == null)
            {
                keydate = string.Empty;
            }
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            List<HDnhap> kq = new List<HDnhap>();
            foreach (HDnhap h in DSHD)
            {
                if (h.MaHD.IndexOf(keyword) != -1 && h.NgayNhap.IndexOf(keydate) != -1)
                {
                    kq.Add(h);
                }
            }
            return kq;
        }
        public static bool KiemTraID(string id)
        {
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            foreach (HDnhap h in DSHD)
            {
                if (h.MaHD == id)
                {
                    return true;
                }
            }
            return false;
        }

        public static string XoaHD(string id)
        {
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            for (int i=0; i<DSHD.Count(); i++)
            {
                if (DSHD[i].MaHD == id)
                {
                    DSHD.RemoveAt(i);
                    LuuTruHDNhap.LuuDSNhap(DSHD);
                    return "Xóa thành công";
                }
            }
            return "Xóa thất bại, không tìm thấy mã hóa đơn";

        }
        public static HDnhap ThongTinHD(string id)
        {
            HDnhap hf = new HDnhap();
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            foreach (HDnhap h in DSHD)
            {
                if (h.MaHD == id)
                {
                    return h;
                }
            }
            return hf;
        }

        public static string SuaHD(string id, HDnhap h)
        {
            List<HDnhap> DSHD = LuuTruHDNhap.DocHDNhap();
            for (int i = 0; i < DSHD.Count(); i++)
            {
                if (DSHD[i].MaHD == id) //Tim vi tri cua HD
                {
                    for (int j = 0; j < DSHD.Count(); j++)
                    {
                        if (i != j && DSHD[j].MaHD == h.MaHD) //Kiem tra HD moi co trung id voi cac hoa don khac khong
                        {
                            return "Trùng mã hóa đơn, chỉnh sửa thất bại";
                        }
                    }
                    //kiem tra hang hoa loi du lieu
                    List<PhieuHH> HHdakiem = new List<PhieuHH>();
                    foreach (PhieuHH hh in h.DSNhapHang)
                    {
                        if (hh.MaMH != null && hh.Gia != 0 && hh.SoLuong != 0)
                        {
                            HHdakiem.Add(hh);
                        }
                    }
                    if (HHdakiem.Count() == 0)
                    {
                        return "Du lieu sai, vui long nhap lai";
                    }
                    else
                    {
                        h.DSNhapHang = HHdakiem;
                        DSHD[i] = h;
                        LuuTruHDNhap.LuuDSNhap(DSHD);
                        return "Chỉnh sửa thành công";
                    }
                        
                }
            }

            //số lượng phải lớn hơn hoặc bằng tổng lượng đã bán - chưa làm
            return "Chỉnh sửa thất bại, dữ liệu không phù hợp";
        }
    }
}
