using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages.LoaiHang
{
    public class MH_TimKiemModel : PageModel
    {
        public string Ketqua;
        public List<Loaihang> DSLH;
        public IXuLyLoaiHang xuly;
        [BindProperty]
        public string keyword { get; set; }
        public MH_TimKiemModel()
        {
            xuly = new XuLyLoaiHang();
        }
        public void OnGet()
        {
            Ketqua = string.Empty;
            DSLH = new List<Loaihang>();
        }
        public void OnPost()
        {
            DSLH = xuly.TimKiemLoaiHang(null);
        }
    }
}
