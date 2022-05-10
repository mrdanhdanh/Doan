using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLyLoaiHang
    {
        ServiceResult<bool> ThemLoaiHang(Loaihang l);
        List<Loaihang> TimKiemLoaiHang(string keyword);
    }
}
