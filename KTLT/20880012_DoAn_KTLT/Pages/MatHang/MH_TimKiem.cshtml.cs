using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;

namespace _20880012_DoAn_KTLT.Pages.MatHang
{
    public class MH_TimKiemModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH;

        [BindProperty]
        public string Keyword { get; set; }
        public void OnGet()
        {
            Ketqua = string.Empty;
            DSMH = new List<Mathang>();
        }

        public void OnPost()
        {
            DSMH = XuLyMatHang.TimKiemMatHang(Keyword);
        }
    }
}
