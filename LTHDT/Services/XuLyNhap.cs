using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DAL;

namespace Services
{
    public class XuLyNhap : XuLyHoaDon, IXuLyHoaDon
    {
        public ILuuTruHoaDon luutru;
        public XuLyNhap()
        {
            luutru = new LuuTruNhap();
        }
        public ServiceResult<List<Hoadon>> TimKiemHD(string keyword, string keydate)
        {
            List<Hoadon> DSHD = luutru.DocDSHD();
            return TimKiemHoadon(DSHD, keyword, keydate);
        }
        public override ServiceResult<Hoadon> ThongTinHD(string id)
        {
            List<Hoadon> DSHD = luutru.DocDSHD();
            foreach (Hoadon h in DSHD)
            {
                if (h.MaHD == id)
                {
                    return new ServiceResult<Hoadon>(true, h, null);
                }
            }
            return new ServiceResult<Hoadon>(false, null, "Không tìm thấy mã hóa đơn");
        }
        public override ServiceResult<bool> XoaHD(string id)
        {
            var kq = ThongTinHD(id);
            if (kq.IsSuccess)
            {
                if (KiemTraTonKho(kq.Data.DShanghoa))
                {
                    if (luutru.XoaID(id))
                    {
                        return new ServiceResult<bool>(true, true, "Xóa thành công");
                    } else
                    {
                        return new ServiceResult<bool>(false, false, "Xóa thất bại, không tìm thấy id");
                    }
                } else
                {
                    return new ServiceResult<bool>(false, false, "Không thể xóa do sẽ khiến tồn kho bị âm");
                }
            }
            else
            {
                return new ServiceResult<bool>(false, false, "Không tìm thấy mã hóa đơn, không thể xóa");
            }
        }
        public override ServiceResult<bool> TaoHD(Hoadon h)
        {
            List<Hoadon> DSHD = luutru.DocDSHD();
            foreach (Hoadon hd in DSHD)
            {
                if (hd.KiemTraTrung(h))
                {
                    return new ServiceResult<bool>(false, false, "Trùng mã hóa đơn, không thể tạo mới");
                }
            }
            luutru.LuuHD(h);
            return new ServiceResult<bool>(true, true, "Lưu thành công");
        }
        public override ServiceResult<Hoadon> SuaHD(string id, Hoadon h)
        {
            List<Hoadon> DSHD = luutru.DocDSHD();
            for (int i = 0; i < DSHD.Count; i++)
            {
                if (DSHD[i].MaHD == id)
                {
                    foreach (Hoadon hd in DSHD)
                    {
                        if (h.MaHD != id && hd.KiemTraTrung(h))
                        {
                            throw new Exception("Trùng mã hóa đơn, không thể sửa");
                        }
                    }
                    if (KiemTraTonKhoSua(h.DShanghoa, DSHD[i].DShanghoa))
                    {
                        DSHD[i] = h;
                        luutru.LuuDSHD(DSHD);
                        return new ServiceResult<Hoadon>(true, h, "Sửa hóa đơn thành công");
                    } else
                    {
                        return new ServiceResult<Hoadon>(false, h, "Không thể sửa do sẽ khiến tồn kho bị âm");
                    }
                    
                }
            }
            return new ServiceResult<Hoadon>(false, h, "Không tìm thấy mã hóa đơn, không thể sửa");
        }
        public override void SuaHDkhiSuaMH(string mhold, string mhnew)
        {
            List<Hoadon> DSHD = luutru.DocDSHD();
            foreach (Hoadon h in DSHD)
            {
                foreach (PhieuHH hh in h.DShanghoa)
                {
                    if (hh.MaMH == mhold)
                    {
                        hh.MaMH = mhnew;
                    }
                }
            }
            luutru.LuuDSHD(DSHD);
        }
    }
}
