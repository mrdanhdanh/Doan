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
        public List<Tonkho> DSTK;
        public List<Mathang> DSMH = XuLyMatHang.TimKiemMatHang(null);
        public string MatHang;
        [BindProperty] 
        public string MaMH { get; set; }

        public void OnGet()
        {
            DSTK = XuLyTonKho.TaiDSTonKho(null);
        }

        public void OnPost()
        {
            DSTK = XuLyTonKho.TaiDSTonKho(null);
        }
    }
}
