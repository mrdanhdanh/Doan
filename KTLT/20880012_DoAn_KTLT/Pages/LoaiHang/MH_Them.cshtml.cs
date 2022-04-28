using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;

namespace _20880012_DoAn_KTLT.Pages.LoaiHang
{
    [BindProperties]
    public class MH_ThemModel : PageModel
    {
        public string Chuoi;

        public string MaLH { get; set; }
        public string TenLH { get; set; }

        public void OnGet()
        {
            Chuoi = string.Empty;
        }

        public void OnPost()
        {
            Loaihang l;
            l.MaLoaiHang = MaLH;
            l.TenLoaiHang = TenLH;
            bool kq = XuLyLoaiHang.TaoLoaiHang(l);
            if (kq)
            {
                Chuoi = "Tạo loại hàng mới thành công";
            }
            else
            {
                Chuoi = "Dữ liệu lỗi hoặc trùng, tạo mới thất bại";
            }
        }
    }
}
