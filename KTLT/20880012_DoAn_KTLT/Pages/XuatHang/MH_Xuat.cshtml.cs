using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;

namespace _20880012_DoAn_KTLT.Pages.XuatHang
{
    [BindProperties]
    public class MH_XuatModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH = XuLyMatHang.TimKiemMatHang(null);
        public List<Tonkho> DSTK;

        public string MatHang;
        public string MaHD { get; set; }
        public string NgayXuat { get; set; }
        public string MaMH { get; set; }
        public int SL { get; set; }

        public void TaiTonKho()
        {
            DSTK = XuLyTonKho.TaiDSTonKho(null);
            if (DSTK.Count() == 0)
            {
                Ketqua = "Kho không còn hàng để bán, vui lòng nhập hàng trước khi xuất hóa đơn bán";
            }
        }
        public void OnGet()
        {
            TaiTonKho();
        }
        public void OnPost()
        {
            TaiTonKho();
            HDxuat h = new HDxuat();
            h.MaHD = MaHD;
            h.NgayXuat = NgayXuat;
            h.MaMH = MaMH;
            h.SoLuong = SL;
            Ketqua = XuLyXuat.XuatHD(h);
        }
    }
}
