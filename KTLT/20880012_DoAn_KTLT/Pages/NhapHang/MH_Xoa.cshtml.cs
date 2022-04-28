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
    public class MH_XoaModel : PageModel
    {
        public string Ketqua;
        public bool checkid;

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public void OnGet()
        {
            checkid = XuLyNhap.KiemTraID(id);
            if (checkid)
            {
                Ketqua = "Bạn có chác chắn muốn xóa hóa đơn " + id + " không. Dữ liệu sẽ không thể phục hồi";

            } else
            {
                Ketqua = "Không tìm thấy hóa đơn " + id + ", không thể xóa";
            }
            
        }
        public void OnPost()
        {
            Ketqua = XuLyNhap.XoaHD(id);
        }
    }
}
