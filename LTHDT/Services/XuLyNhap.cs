using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DAL;

namespace Services
{
    public class XuLyNhap : IXuLyNhap
    {
        public ILuuTruNhap luutru;
        public XuLyNhap()
        {
            luutru = new LuuTruNhap();
        }
        public ServiceResult<List<Hoadon>> TimKiemHDnhap(string keyword, string keydate)
        {
            List<Hoadon> DSHD = luutru.DocDSHDnhap();
            if (keyword == null && keydate == null)
            {
                return new ServiceResult<List<Hoadon>>(true, DSHD, null);
            } else
            {
                if (keyword == null) {
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
                } else
                {
                    return new ServiceResult<List<Hoadon>>(true, DSloc, null);
                }
            }
        }
    }
}
