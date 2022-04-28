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
    public class MH_NhapModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH;

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
            TaiMatHang();
        }
        public void OnPost()
        {
            TaiMatHang();
            HDnhap h = new HDnhap();
            h.MaHD = MaHD;
            h.NgayNhap = NgayNhap;
            h.MaMH = MaMH;
            h.SoLuong = SL;
            if (XuLyNhap.NhapHD(h))
            {
                Ketqua = "Nhập hóa đơn thành công";
            } else
            {
                Ketqua = "Dữ liệu lỗi hoặc trùng, nhập thất bại";
            }
        }
    }
}
