using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;

namespace _20880012_DoAn_KTLT.Pages.NhapHang
{
    [BindProperties]
    public class MH_TimKiemModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH = XuLyMatHang.TimKiemMatHang("");
        public List<HDnhap> DSHD;
        public string MatHang;

        public string Keyword { get; set; }
        public string Keydate { get; set; }

        public void OnGet()
        {
            DSHD = new List<HDnhap>();
            Ketqua = string.Empty;
        }
        public void OnPost() {
            DSHD = XuLyNhap.TimKiemHD(Keyword, Keydate);
            if (DSHD.Count()==0)
            {
                Ketqua = "Không tìm thấy hóa đơn phù hợp";
            }
        }
    }
}
