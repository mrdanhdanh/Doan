using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DAL
{
    public interface ILuuTruHoaDon
    {
        List<Hoadon> DocDSHD();
        bool XoaID(string id);
        void LuuHD(Hoadon h);
    }
}
