using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace _20880012_DoAn_LTHDT.Pages.LoaiHang
{
    [BindProperties]
    public class MH_ThemModel : PageModel
    {
        public string Chuoi;
        private IXuLyLoaiHang xuly;
        public string MaLH { get; set; }
        public string TenLH { get; set; }

        public MH_ThemModel()
        {
            xuly = new XuLyLoaiHang();
        }
        public void OnGet()
        {
            Chuoi = string.Empty;
        }

        public void OnPost()
        {
            try
            {
                Loaihang l = new Loaihang(MaLH, TenLH);
                var kq = xuly.ThemLoaiHang(l);
                Chuoi = kq.Message;
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        } 
    }
}
