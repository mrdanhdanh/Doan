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
    public class MH_TimKiemModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH = new List<Mathang>();
        public IXuLyMatHang xuly;
        [BindProperty(SupportsGet = true)]
        public string Keyword { get; set; }

        public MH_TimKiemModel()
        {
            xuly = new XuLyMatHang();
        }
        public void OnGet()
        {
            Ketqua = String.Empty;
        }

        public void OnPost()
        {
            try
            {
                var kq = xuly.TimKiemMatHang(Keyword);
                if (kq.IsSuccess)
                {
                    DSMH = kq.Data;
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
