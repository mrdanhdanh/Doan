using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages.XuatHang
{
    public class MH_ThemModel : PageModel
    {
        public string Ketqua;

        public bool KiemTra = false;
        public IXuLyTonKho xulyTK;
        public IXuLyHoaDon xulyHD;
        public List<TonkhoMH> DSTK;
        public List<PhieuHH> DSHH = new List<PhieuHH>();

        [BindProperty]
        public string MaHD { get; set; }
        [BindProperty]
        public string NgayTao { get; set; }
        [BindProperty]
        public int DemSP { get; set; }

        public MH_ThemModel()
        {
            xulyTK = new XuLyTonKho();
            xulyHD = new XuLyXuat();
        }
        public void OnGet()
        {
            try
            {
                DemSP = 1;
                var kq = xulyTK.TaoTonKhoMH();
                KiemTra = kq.IsSuccess;
                DSTK = kq.Data;
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
                for (int i = 0; i < DemSP; i++)
                {
                    var mamh = "mamh" + i;
                    var gia = "gia" + i;
                    var sl = "sl" + i;
                    PhieuHH hh = new PhieuHH(Request.Form[mamh], int.Parse(Request.Form[gia]), int.Parse(Request.Form[sl]));
                    DSHH.Add(hh);
                }
                HDxuat h = new HDxuat();
                h.TaoHoadon(MaHD, NgayTao, DSHH);
                var kq = xulyHD.TaoHD(h);
                Ketqua = kq.Message;
                DSTK = xulyTK.TaoTonKhoMH().Data;
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }

        }
    }
}
