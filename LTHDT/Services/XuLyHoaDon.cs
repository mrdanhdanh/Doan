using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public abstract class XuLyHoaDon
    {
        public ServiceResult<List<Hoadon>> TimKiemHoadon(List<Hoadon> DSHD, string keyword, string keydate)
        {
            if (keyword == null && keydate == null)
            {
                return new ServiceResult<List<Hoadon>>(true, DSHD, null);
            }
            else
            {
                if (keyword == null)
                {
                    keyword = String.Empty;
                }
                if (keydate == null)
                {
                    keydate = String.Empty;
                }
                List<Hoadon> DSloc = new List<Hoadon>();
                foreach (Hoadon hd in DSHD)
                {
                    if (hd.MaHD.Contains(keyword) && hd.NgayTao.Contains(keydate))
                    {
                        DSloc.Add(hd);
                    }
                }
                if (DSloc.Count == 0)
                {
                    return new ServiceResult<List<Hoadon>>(false, null, "Không tìm thấy hóa đơn phù hợp");
                }
                else
                {
                    return new ServiceResult<List<Hoadon>>(true, DSloc, null);
                }
            }
        }

        public abstract ServiceResult<Hoadon> ThongTinHD(string id);

        public abstract ServiceResult<bool> XoaHD(string id);

        public abstract ServiceResult<bool> TaoHD(Hoadon h);
    }
}
