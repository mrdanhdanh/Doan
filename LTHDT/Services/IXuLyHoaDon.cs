using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLyHoaDon
    {
        ServiceResult<List<Hoadon>> TimKiemHD(string keyword, string keydate);
        ServiceResult<Hoadon> ThongTinHD(string id);
        ServiceResult<bool> XoaHD(string id);
    }
}
