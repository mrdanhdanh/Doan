using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLyMatHang
    {
        ServiceResult<List<Mathang>> TimKiemMatHang(string keyword);
        ServiceResult<Mathang> DocMatHang(string id);
        string XoaMatHang(string id);
        string ThemMatHang(Mathang m);
        string SuaMatHang(string id, Mathang m);
        void SuaMHkhiSuaLH(string lold, string lnew);
        void XoaMHkhiXoaLH(string tenlh);
    }
}
