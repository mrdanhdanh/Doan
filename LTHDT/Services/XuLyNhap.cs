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
            bool isXoa = luutru.XoaID(id);
            if (isXoa)
            {
                return new ServiceResult<bool>(true, true, "Xóa thành công");
            }
            else
            {
                return new ServiceResult<bool>(false, false, "Không tìm thấy mã hóa đơn, không thể xóa");
            }
        }
    }
}
