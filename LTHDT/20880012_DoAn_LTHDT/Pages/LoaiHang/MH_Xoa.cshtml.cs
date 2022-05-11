using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages.LoaiHang
{
    public class MH_XoaModel : PageModel
    {
        public string Ketqua;
        public bool KiemTraID;
        private IXuLyLoaiHang xuly;

        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }
        public MH_XoaModel()
        {
            xuly = new XuLyLoaiHang();
        }
        public void OnGet()
        {
            try
            {
                KiemTraID = xuly.DocLoaiHang(ID).IsSuccess;
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
                Ketqua = xuly.XoaLoaiHang(ID).Message;
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
    }
}
