using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages
{
    public class ThongketonkhoModel : PageModel
    {
        public string ThongBao;
        public bool KiemTra;
        public IXuLyTonKho xuly;
        public List<TonkhoLH> DSloc = new List<TonkhoLH>();

        [BindProperty]
        public string KeyWord { get; set; }

        public ThongketonkhoModel()
        {
            xuly = new XuLyTonKho();
        }
        public void OnGet()
        {
            ThongBao = String.Empty;
        }
        public void OnPost()
        {
            try
            {
                var kq = xuly.TaiTonKhoLH(KeyWord);
                ThongBao = kq.Message;
                if (kq.IsSuccess)
                {
                    DSloc = kq.Data;
                }
            }
            catch (Exception ex)
            {
                ThongBao = ex.Message;
            }
        }
    }
}
