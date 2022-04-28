using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;

namespace _20880012_DoAn_KTLT.Pages.MatHang
{
    public class MH_XoaModel : PageModel
    {
        public string Ketqua;
        public bool kiemtraID;
        [BindProperty(SupportsGet =true)]
        public string id { get; set; }
        public void OnGet()
        {
            kiemtraID = XuLyMatHang.TimKiemID(id);
            if (kiemtraID == false)
            {
                Ketqua = "Mã mặt hàng không tồn tại";
            }
        }

        public void OnPost()
        {
            if (XuLyMatHang.XoaMatHang(id))
            {
                Ketqua = "Xóa mặt hàng thành công";
            } else
            {
                Ketqua = "Không tìm thấy mặt hàng, xóa thất bại";
            }
        }
    }
}
