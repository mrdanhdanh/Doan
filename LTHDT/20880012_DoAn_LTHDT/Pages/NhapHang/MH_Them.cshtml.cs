using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages.NhapHang
{
    public class MH_ThemModel : PageModel
    {
        public string Ketqua;
        public int demsp = 1;
        public bool KiemTra = false;
        public IXuLyMatHang xulyMH;
        public IXuLyHoaDon xulyHD;
        public List<Mathang> DSMH;
        public List<PhieuHH> DSHH = new List<PhieuHH>();

        [BindProperty]
        public string MaHD { get; set; }
        [BindProperty]
        public string NgayTao { get; set; }

        public MH_ThemModel()
        {
            xulyMH = new XuLyMatHang();
            xulyHD = new XuLyNhap();
        }
        public void OnGet()
        {
            try
            {
                var kq = xulyMH.TimKiemMatHang(null);
                KiemTra = kq.IsSuccess;
                DSMH = kq.Data;
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
                demsp = int.Parse(Request.Form["demsp"]);
                for (int i = 0; i < demsp; i++)
                {
                    var mamh = "mamh" + i;
                    var gia = "gia" + i;
                    var sl = "sl" + i;
                    PhieuHH hh = new PhieuHH(Request.Form[mamh], int.Parse(Request.Form[gia]), int.Parse(Request.Form[sl]));
                    DSHH.Add(hh);
                }
                HDnhap h = new HDnhap();
                h.TaoHoadon(MaHD, NgayTao, DSHH);
                var kq = xulyHD.TaoHD(h);
                Ketqua = kq.Message;
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
            DSMH = xulyMH.TimKiemMatHang(null).Data;
        }
    }
}
