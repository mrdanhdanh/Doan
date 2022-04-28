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
    public class MH_SuaModel : PageModel
    {
        public string Ketqua;
        public bool kiemtraID;

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }

        [BindProperty]
        public string MaLH { get; set; }
        [BindProperty]
        public string TenLH { get; set; }
        public void OnGet()
        {
            
            kiemtraID = XuLyLoaiHang.TimID(id);
            if (kiemtraID)
            {
                Loaihang l = XuLyLoaiHang.LayTTLoaiHang(id);
                MaLH = l.MaLoaiHang;
                TenLH = l.TenLoaiHang;
            } else
            {
                Ketqua = "Không tìm thấy mã loại hàng " + id + ". Không thể chỉnh sửa";
            }
            
        }

        public void OnPost()
        {
            kiemtraID = XuLyLoaiHang.TimID(id);
            bool kqSua = XuLyLoaiHang.SuaLoaiHang(id, MaLH, TenLH);
            if (kqSua)
            {
                Ketqua = "Chỉnh sửa thành công";
                id = MaLH;
            } else
            {
                Ketqua = "Chỉnh sửa thất bại, dữ liệu nhập lỗi hoặc bị trùng";
            }

        }


    }
}
