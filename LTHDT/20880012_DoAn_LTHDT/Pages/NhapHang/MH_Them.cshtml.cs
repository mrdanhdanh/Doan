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
        public bool KiemTra = false;
        public IXuLyMatHang xulyMH;
        public IXuLyHoaDon xulyHD;
        public List<Mathang> DSMH;
        public List<PhieuHH> DSHH = new List<PhieuHH>();

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
            int tong = 0;
            for (int i = 0; i<DSHH.Count; i++)
            {
                tong += DSHH[i].SoLuong;
            }
            Ketqua = "Test: " + tong;
            var kq = xulyMH.TimKiemMatHang(null);
            KiemTra = kq.IsSuccess;
            DSMH = kq.Data;
        }
    }
}
