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
    public class ThongkehangcuModel : PageModel
    {
        public List<Mathang> DSMH = XuLyMatHang.TimKiemMatHang(null);
        public List<TonkhoMH> DSTK;

        [BindProperty]
        public string MaMH { get; set; }

        public void OnGet()
        {
            DSTK = XuLyTonKho.TaiDSHetHan(null);
        }
        public void OnPost()
        {
            DSTK = XuLyTonKho.TaiDSHetHan(MaMH);
        }
    }
}
