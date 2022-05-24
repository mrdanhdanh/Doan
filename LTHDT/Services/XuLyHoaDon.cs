using System;
using System.Linq;
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

        public abstract ServiceResult<Hoadon> SuaHD(string id, Hoadon h);

        public bool KiemTraTonKho(List<PhieuHH> DSHH) //Dùng kiểm tra khi tạo hóa đơn bán mới hoặc xóa hóa đơn nhập
        {
            IXuLyTonKho xulyTK = new XuLyTonKho();
            List<TonkhoMH> DSTK = xulyTK.TaoTonKhoMH().Data;

            foreach (PhieuHH hh in DSHH)
            {
                var target = DSTK.FirstOrDefault(t => t.MaMH == hh.MaMH);
                if (target == null) { //Nếu có sp nào không xuất hiện trong tồn kho, hay tồn kho của nó = 0 => trả về false do không thể giảm nữa
                    return false;
                } else
                {
                    foreach (TonkhoMH t in DSTK)
                    {
                        t.SuaTonKho(hh, false);
                        if (t.TonKho < 0)
                        {
                            return false;
                        }
                    }
                }
                
            }
            return true;
        }

        public bool KiemTraTonKhoSua(List<PhieuHH> HHthem, List<PhieuHH> HHxoa)
        {
            IXuLyTonKho xulyTK = new XuLyTonKho();
            List<TonkhoMH> DSTK = xulyTK.TaoTonKhoMH().Data;

            foreach (PhieuHH hh in HHthem)
            {
                var target = DSTK.FirstOrDefault(t => t.MaMH == hh.MaMH);
                if (target == null)
                {
                    TonkhoMH tk = new TonkhoMH();
                    tk.MaMH = hh.MaMH;
                    tk.TonKho = hh.SoLuong;
                    DSTK.Add(tk);
                } else
                {
                    foreach (TonkhoMH t in DSTK)
                    {
                        t.SuaTonKho(hh, true);
                    }
                }
            }
            foreach (PhieuHH hh in HHxoa)
            {
                var target = DSTK.FirstOrDefault(t => t.MaMH == hh.MaMH);
                if (target == null)
                { //Nếu có sp nào không xuất hiện trong tồn kho, hay tồn kho của nó = 0 => trả về false do không thể giảm nữa
                    return false;
                }
                else
                {
                    foreach (TonkhoMH t in DSTK)
                    {
                        t.SuaTonKho(hh, false);
                        if (t.TonKho < 0)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public abstract void SuaHDkhiSuaMH(string mhold, string mhnew);
    }
}
