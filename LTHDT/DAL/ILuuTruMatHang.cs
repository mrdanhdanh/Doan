using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DAL
{
    public interface ILuuTruMatHang
    {
        List<Mathang> DocDSMH();
        List<Mathang> TimKiem(string keyword);
        Mathang DocID(string id);
        bool XoaID(string id);
        void LuuMatHang(Mathang m);
        void LuuDSMH(List<Mathang> danhsachMatHang);
    }
}
