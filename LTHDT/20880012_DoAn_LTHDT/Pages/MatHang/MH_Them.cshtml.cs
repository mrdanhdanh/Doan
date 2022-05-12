using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages.MatHang
{
    [BindProperties]
    public class MH_ThemModel : PageModel
    {
        public IXuLyMatHang xulyMH;
        public IXuLyLoaiHang xulyLH;
        public string Ketqua;
        public bool KiemTra = false;
        public List<Loaihang> DSLH;

        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string CtySX { get; set; }
        public string TenLH { get; set; }
        public int Gia { get; set; }
        public string NgaySX { get; set; }
        public string HanSD { get; set; }

        public MH_ThemModel()
        {
            xulyMH = new XuLyMatHang();
            xulyLH = new XuLyLoaiHang();
        }
        public void OnGet()
        {
            try
            {
                DSLH = xulyLH.TimKiemLoaiHang(null);
                KiemTra = true;
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                Mathang m = new Mathang(MaMH, TenMH, CtySX, TenLH, Gia, NgaySX, HanSD);
                Ketqua = xulyMH.ThemMatHang(m);
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
    }
}
