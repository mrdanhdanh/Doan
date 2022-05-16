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
    public class MH_XoaModel : PageModel
    {
        public string ThongBao;
        public bool KiemTra = false;
        public IXuLyHoaDon xuly;

        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }

        public MH_XoaModel()
        {
            xuly = new XuLyNhap();
        }
        public void OnGet()
        {
            try
            {
                var kq = xuly.ThongTinHD(ID);
                KiemTra = kq.IsSuccess;
                ThongBao = kq.Message;
            }
            catch (Exception ex)
            {
                ThongBao = ex.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                var kq = xuly.XoaHD(ID);
                ThongBao = kq.Message;
            }
            catch (Exception ex)
            {
                ThongBao = ex.Message;
            }
        }
    }
}
