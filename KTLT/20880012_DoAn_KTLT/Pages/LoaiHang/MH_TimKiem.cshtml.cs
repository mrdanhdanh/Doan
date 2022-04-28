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
    public class MH_TimKiemModel : PageModel
    {
        public string Ketqua;
        public List<Loaihang> DSLH;
        
        [BindProperty]
        public string keyword { get; set; }
        public void OnGet()
        {
            Ketqua =  string.Empty;
            DSLH = new List<Loaihang>();
        }
        public void OnPost()
        {
            DSLH = XuLyLoaiHang.TimKiemLoaiHang(keyword);
        }
    }
}
