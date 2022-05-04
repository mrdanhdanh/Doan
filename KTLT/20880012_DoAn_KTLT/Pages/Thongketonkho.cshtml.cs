using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;

namespace _20880012_DoAn_KTLT.Pages
{
    public class TonkhoModel : PageModel
    {
        public List<TonkhoLH> DSTK;
        public List<Loaihang> DSLH = XuLyLoaiHang.TimKiemLoaiHang(null);
        [BindProperty] 
        public string MaLH { get; set; }

        public void OnGet()
        {
            DSTK = XuLyTonKho.TaiDSTonKhoLH(null);
        }

        public void OnPost()
        {
            DSTK = XuLyTonKho.TaiDSTonKhoLH(MaLH);
        }
    }
}
