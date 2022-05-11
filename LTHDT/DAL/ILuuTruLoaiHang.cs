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
        List<Loaihang> TimKiem(string keyword);
        Loaihang TimKiemID(string id);
        bool XoaID(string id);
        bool SuaLH(string id, Loaihang l);
    }
}
