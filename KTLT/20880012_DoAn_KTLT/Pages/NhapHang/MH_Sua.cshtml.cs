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
    [BindProperties]
    public class MH_SuaModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH;
        public HDnhap h;

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public string MaHD { get; set; }
        public string NgayNhap { get; set; }
        public string MaMH { get; set; }
        public int SL { get; set; }

        public void TaiMatHang()
        {
            DSMH = XuLyMatHang.TimKiemMatHang("");
            if (DSMH.Count() == 0)
            {
                Ketqua = "Dữ liệu không tồn tại mặt hàng. Vui lòng thêm mặt hàng trước khi nhập hàng";
            }
        }
        public void OnGet()
        {
            h = XuLyNhap.ThongTinHD(id);
            if (h.MaHD != null)
            {
                TaiMatHang();
                MaHD = h.MaHD;
                NgayNhap = h.NgayNhap;
                SL = h.SoLuong;
                MaMH = h.MaMH;
            } else
            {
                MaHD = null;
                Ketqua = "Không tìm thấy mã hóa đơn, không thể chỉnh sửa";
            }
            
        }
        public void OnPost()
        {
            TaiMatHang();
            Ketqua = XuLyNhap.SuaHD(id, MaHD, NgayNhap, MaMH, SL);
        }
    }
}
