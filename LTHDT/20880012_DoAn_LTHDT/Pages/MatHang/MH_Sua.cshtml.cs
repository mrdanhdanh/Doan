using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;
using Entities;

namespace _20880012_DoAn_LTHDT.Pages.MatHang
{
    [BindProperties]
    public class MH_SuaModel : PageModel
    {
        public IXuLyMatHang xulyMH;
        public IXuLyLoaiHang xulyLH;
        public string Ketqua;
        public bool KiemtraID = false;
        public List<Loaihang> DSLH;

        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }

        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string CtySX { get; set; }
        public string TenLH { get; set; }
        public int Gia { get; set; }
        public string NgaySX { get; set; }
        public string HanSD { get; set; }

        public MH_SuaModel()
        {
            xulyMH = new XuLyMatHang();
            xulyLH = new XuLyLoaiHang();
        }
        public void OnGet()
        {
            try
            {
                DSLH = xulyLH.TimKiemLoaiHang(null);
                var kq = xulyMH.DocMatHang(ID);
                KiemtraID = kq.IsSuccess;
                if (KiemtraID)
                {
                    MaMH = kq.Data.MaMatHang;
                    TenMH = kq.Data.TenMatHang;
                    CtySX = kq.Data.CongTySanXuat;
                    TenLH = kq.Data.TenLoaiHang;
                    Gia = kq.Data.Gia;
                    NgaySX = kq.Data.NgaySanXuat;
                    HanSD = kq.Data.HanSuDung;
                }
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
                Ketqua = xulyMH.SuaMatHang(ID, m);
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
    }
}
