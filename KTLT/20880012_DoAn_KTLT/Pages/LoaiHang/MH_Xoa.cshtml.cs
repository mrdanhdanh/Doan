using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;


namespace _20880012_DoAn_KTLT.Pages.LoaiHang
{
    public class MH_XoaModel : PageModel
    {
        public string Ketqua;
        public bool kiemtraID;
        public bool checkXoa;

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public void OnGet()
        {
            Ketqua = string.Empty;
            kiemtraID = XuLyLoaiHang.TimID(id);
            if (kiemtraID == false)
            {
                Ketqua = "Không tìm thấy mã loại hàng "+id+", xóa thất bại.";
            }
        }

        public void OnPost()
        {
            Ketqua = XuLyLoaiHang.XoaLoaiHang(id);
        }
    }
}
