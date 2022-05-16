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
    public class MH_TimKiemModel : PageModel
    {
        public string Ketqua;
        public bool KiemTra;
        public IXuLyMatHang xulyMH;
        public IXuLyHoaDon xulyHD;
        public List<Mathang> DSMH;
        public List<Hoadon> DSHD;

        [BindProperty]
        public string Keyword { get; set; }
        [BindProperty]
        public string Keydate { get; set; }

        public MH_TimKiemModel()
        {
            xulyMH = new XuLyMatHang();
            xulyHD = new XuLyNhap();
        }

        
        public void OnGet()
        {
            try
            {
                var kq = xulyMH.TimKiemMatHang(null);
                DSMH = kq.Data;
                KiemTra = kq.IsSuccess;
                Ketqua = kq.Message;
                if (KiemTra)
                {
                    DSHD = new List<Hoadon>();
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
                var kq = xulyHD.TimKiemHD(Keyword, Keydate);
                if (kq.IsSuccess)
                {
                    KiemTra = true;
                    DSHD = kq.Data;
                    DSMH = xulyMH.TimKiemMatHang(null).Data;
                } else
                {
                    Ketqua = kq.Message;
                }
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
    }
}
