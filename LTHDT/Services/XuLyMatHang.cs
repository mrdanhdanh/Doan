using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DAL;

namespace Services
{
    public class XuLyMatHang : IXuLyMatHang
    {
        public ILuuTruMatHang luutru;
        public XuLyMatHang()
        {
            luutru = new LuuTruMatHang();
        }
        public ServiceResult<List<Mathang>> TimKiemMatHang(string keyword)
        {
            List<Mathang> DSMH = luutru.TimKiem(keyword);
            if (DSMH.Count == 0)
            {
                return new ServiceResult<List<Mathang>>(false, null, "Không tìm thấy mặt hàng");
            } else
            {
                return new ServiceResult<List<Mathang>>(true, DSMH, null);
            }
            
        }
        public ServiceResult<Mathang> DocMatHang(string id)
        {
            Mathang m = luutru.DocID(id);
            if (m == null)
            {
                return new ServiceResult<Mathang>(false, null, "Không tìm thấy mặt hàng, không thể xóa");
            } else
            {
                return new ServiceResult<Mathang>(true, luutru.DocID(id), null);
            }
        }

        public string XoaMatHang(string id)
        {
            if (luutru.XoaID(id))
            {
                return "Xóa thành công";
            } else
            {
                return "Không tìm thấy mặt hàng, xóa thất bại";
            }
            //Chưa làm phần xóa thông tin hóa đơn nhập và xuất
        }
        public string ThemMatHang(Mathang m)
        {
            List<Mathang> DSMH = luutru.DocDSMH();
            foreach (Mathang mh in DSMH)
            {
                if (mh.KiemTraTrung(m))
                {
                    return "Trùng mã mặt hàng, không thể thêm mới";
                }
            }
            luutru.LuuMatHang(m);
            return "Thêm mặt hàng thành công";
        }
    }
}
