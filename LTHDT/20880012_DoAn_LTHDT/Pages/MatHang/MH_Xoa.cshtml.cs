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
    public class MH_XoaModel : PageModel
    {
        public string Ketqua;
        public IXuLyMatHang xuly;
        public bool KiemtraID = false;

        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }

        public MH_XoaModel()
        {
            xuly = new XuLyMatHang();
        }
        public void OnGet()
        {
            try
            {
                var kq = xuly.DocMatHang(ID);
                KiemtraID = kq.IsSuccess;
                Ketqua = kq.Message;
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
                Ketqua = xuly.XoaMatHang(ID);
                KiemtraID = false;
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
    }
}
