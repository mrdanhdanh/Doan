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
    public class ThongkehangcuModel : PageModel
    {
        public IXuLyTonKho xuly;
        public List<TonkhoMH> DSTK;
        public List<TonkhoMH> DSloc;
        public string ThongBao;
        public bool KiemTra;
        [BindProperty]
        public string MaMH { get; set; }
        [BindProperty]
        public string OutDate { get; set; }
        public ThongkehangcuModel()
        {
            xuly = new XuLyTonKho();
        }
        public void OnGet()
        {
            try
            {
                OutDate = null;
                var kq = xuly.TaoTonKhoMH();
                KiemTra = kq.IsSuccess;
                DSTK = kq.Data;
                DSloc = new List<TonkhoMH>();
            }
            catch (Exception ex) {
                ThongBao = ex.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                var kq = xuly.TaoTonKhoMH();
                KiemTra = kq.IsSuccess;
                DSTK = kq.Data;
                if (KiemTra)
                {
                    DSloc = xuly.LocTonKhoMH(DSTK, MaMH, OutDate);
                }
            }
            catch (Exception ex)
            {
                ThongBao = ex.Message;
            }
        }
    }
}
