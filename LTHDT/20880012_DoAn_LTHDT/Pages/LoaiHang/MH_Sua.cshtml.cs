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
    public class MH_SuaModel : PageModel
    {
        public string Ketqua;
        public IXuLyLoaiHang xuly;
        public ServiceResult<Loaihang> kq;
        public bool Kiemtra;

        [BindProperty(SupportsGet =true)]
        public string ID { get; set; }
        [BindProperty]
        public string MaLH { get; set; }
        [BindProperty]
        public string TenLH { get; set; }
        public MH_SuaModel()
        {
            xuly = new XuLyLoaiHang();
        }
        public void OnGet()
        {
            try
            {
                kq = xuly.DocLoaiHang(ID);
                if (kq.IsSuccess == false)
                {
                    Ketqua = kq.Message;
                }
                Kiemtra = kq.IsSuccess;
            }
            catch (Exception ex)
            {
                Kiemtra = false;
                Ketqua = ex.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                Loaihang l = new Loaihang(MaLH, TenLH);
                kq = xuly.SuaLoaiHang(ID,l);
                Kiemtra = kq.IsSuccess;
                Ketqua = kq.Message;
            }
            catch (Exception ex)
            {
                Kiemtra = false;
                Ketqua = ex.Message;
            }
        }
    }
}
