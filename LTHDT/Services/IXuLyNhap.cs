using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLyNhap
    {
        ServiceResult<List<Hoadon>> TimKiemHDnhap(string keyword, string keydate);
    }
}
