using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DAL
{
    public interface ILuuTruLoaiHang
    {
        List<Loaihang> DocDSLH();
        void LuuLoaiHang(Loaihang l);
    }
}
