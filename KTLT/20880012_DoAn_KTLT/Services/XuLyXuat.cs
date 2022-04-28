using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.DAL;

namespace _20880012_DoAn_KTLT.Services
{
    public class XuLyXuat
    {
        public static bool XuatHD(HDxuat x)
        {
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            foreach (HDxuat xh in DSHD)
            {
                if (xh.MaHD == x.MaHD)
                {
                    return false;
                }
            }
            LuuTruHDXuat.LuuHDXuat(x);
            return true;
        }
        public static List<HDxuat> TimKiemHD(string keyword, string keydate)
        {
            if (keyword == null)
            {
                keyword = string.Empty;
            }
            if (keydate == null)
            {
                keydate = string.Empty;
            }
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            List<HDxuat> kq = new List<HDxuat>();
            foreach (HDxuat x in DSHD)
            {
                if (x.MaHD.IndexOf(keyword) != -1 && x.NgayXuat.IndexOf(keydate) != -1)
                {
                    kq.Add(x);
                }
            }
            return kq;
        }
        public static bool KiemTraID(string id)
        {
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            foreach (HDxuat x in DSHD)
            {
                if (x.MaHD == id)
                {
                    return true;
                }
            }
            return false;
        }

        public static string XoaHD(string id)
        {
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            for (int i = 0; i < DSHD.Count(); i++)
            {
                if (DSHD[i].MaHD == id)
                {
                    DSHD.RemoveAt(i);
                    LuuTruHDXuat.LuuDSXuat(DSHD);
                    return "Xóa thành công";
                }
            }
            return "Xóa thất bại, không tìm thấy mã hóa đơn";

        }
        public static HDxuat ThongTinHD(string id)
        {
            HDxuat xf = new HDxuat();
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            foreach (HDxuat x in DSHD)
            {
                if (x.MaHD == id)
                {
                    return x;
                }
            }
            return xf;
        }

        public static string SuaHD(string id, string mahd, string ngaynhap, string mamh, int sl)
        {
            HDxuat hd = new HDxuat();
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            for (int i = 0; i < DSHD.Count(); i++)
            {
                if (DSHD[i].MaHD == id)
                {
                    for (int j = 0; j < DSHD.Count(); j++)
                    {
                        if (i != j && DSHD[j].MaHD == mahd)
                        {
                            return "Trùng mã hóa đơn, chỉnh sửa thất bại";
                        }
                    }
                    hd.MaHD = mahd;
                    hd.NgayXuat = ngaynhap;
                    hd.MaMH = mamh;
                    hd.SoLuong = sl;
                    DSHD[i] = hd;
                    LuuTruHDXuat.LuuDSXuat(DSHD);
                    return "Chỉnh sửa thành công";
                }
            }

            //sau khi sửa -> kiểm tra có lớn hơn soluong nhap hay ko - chưa làm
            return "Chỉnh sửa thất bại, dữ liệu không phù hợp";
        }
    }
}
