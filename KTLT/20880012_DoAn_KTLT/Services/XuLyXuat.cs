using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;
using _20880012_DoAn_KTLT.DAL;

namespace _20880012_DoAn_KTLT.Services
{
    public class XuLyXuat
    {
        public static List<PhieuHH> KiemTraDSBan(List<PhieuHH> DSBH)
        {
            List<PhieuHH> DSKiemTra = new List<PhieuHH>();
            foreach (PhieuHH h in DSBH)
            {
                if (h.MaMH != null && h.SoLuong != 0)
                {
                    DSKiemTra.Add(h);
                }
            }
            return DSKiemTra;
        }
        public static bool KiemTraTonMH(List<PhieuHH> DSHH, string id)
        {
            List<TonkhoMH> DSTK = XuLyTonKho.TaiDSTonKhoMH(null, false);
            if (DSTK.Count() != 0)
            {
                //Nếu id là null -> kiểm tra bình thường; nếu id != null -> đang trong phần sửa hóa đơn, tồn kho sẽ phải bao gồm cả số lượng của các mặt hàng trong hóa đơn có id này
                if (id != null)
                {
                    HDxuat h = ThongTinHD(id);
                    foreach (PhieuHH hh in h.DSBanHang)
                    {
                        for (int i=0; i<DSTK.Count(); i++)
                        {
                            if (hh.MaMH == DSTK[i].MaMH)
                            {
                                TonkhoMH m = DSTK[i];
                                m.SL += hh.SoLuong;
                                DSTK[i] = m;
                            }
                        }
                    }
                }
                foreach (TonkhoMH t in DSTK)
                {
                    foreach (PhieuHH hh in DSHH)
                    {
                        if (t.MaMH == hh.MaMH && t.SL < hh.SoLuong)
                        {
                            return false;
                        }
                    }
                }
            } else
            {
                return false;
            }
            return true;
        }
        public static string XuatHD(HDxuat x)
        {
            //1: Kiểm tra trùng ID
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            foreach (HDxuat xh in DSHD)
            {
                if (xh.MaHD == x.MaHD)
                {
                    return "Trùng mã hóa đơn, vui lòng nhập lại";
                }
            }
            //2: Kiểm tra và loại bỏ các sp bán không đủ thông tin
            List<PhieuHH> DSBH = KiemTraDSBan(x.DSBanHang);
            if (DSBH.Count() == 0)
            {
                return "Dữ liệu sai, vui lòng nhập lại";
            }

            //3: Kiểm tra số lượng phù hợp tồn kho
            if (KiemTraTonMH(DSBH, null))
            {
                //4: Tạo hóa đơn
                x.DSBanHang = DSBH;
                LuuTruHDXuat.LuuHDXuat(x);
                return "Xuất hóa đơn bán thành công";
            } else
            {
                return "Số lượng bán vượt quá số lượng tồn kho, không thể tạo hóa đơn";
            }
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
        public static string SuaHD(string id, HDxuat h)
        {
            HDxuat hd = new HDxuat();
            List<HDxuat> DSHD = LuuTruHDXuat.DocHDXuat();
            for (int i = 0; i < DSHD.Count(); i++)
            {
                if (DSHD[i].MaHD == id)
                {
                    //1:Kiểm tra ID có trùng không
                    for (int j = 0; j < DSHD.Count(); j++)
                    {
                        if (i != j && DSHD[j].MaHD == h.MaHD)
                        {
                            return "Trùng mã hóa đơn, chỉnh sửa thất bại";
                        }
                    }
                    //2:Kiểm tra và loại bỏ các sp không đủ thông tin
                    List<PhieuHH> DSBH = KiemTraDSBan(h.DSBanHang);
                    if (DSBH.Count() == 0)
                    {
                        return "Dữ liệu sai, vui lòng nhập lại";
                    }

                    //3:Kiểm tra Số lượng bán có phù hợp với tồn kho hay không
                    if (KiemTraTonMH(DSBH, id))
                    {
                        //3:Lưu HD Xuất
                        h.DSBanHang = DSBH;
                        DSHD[i] = h;
                        LuuTruHDXuat.LuuDSXuat(DSHD);
                        return "Chỉnh sửa thành công";
                    } else
                    {
                        return "Số lượng bán vượt quá tồn kho, không thể chỉnh sửa";
                    }
                }
            }
            return "Chỉnh sửa thất bại, dữ liệu không phù hợp";
        }
    }
}
