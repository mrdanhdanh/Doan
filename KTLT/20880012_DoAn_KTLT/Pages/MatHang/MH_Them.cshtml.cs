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
    [BindProperties]
    public class MH_ThemModel : PageModel
    {
        public string Ketqua;
        public List<Loaihang> DSLH;

        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string CtySX { get; set; }
        public string TenLH { get; set; }
        public int NamSX { get; set; }
        public int HanSD { get; set; }


        public void TaiLoaiHang()
        {
            DSLH = XuLyLoaiHang.TimKiemLoaiHang("");
            if (DSLH.Count() == 0)
            {
                Ketqua = "Dữ liệu không tồn tại loại hàng. Vui lòng thêm loại hàng trước khi thêm mặt hàng";
            }
        }
        public void OnGet()
        {
            TaiLoaiHang();
        }

        public void OnPost()
        {
            TaiLoaiHang();
            Mathang m = new Mathang();
            m.MaMatHang = MaMH;
            m.TenMatHang = TenMH;
            m.CongTySanXuat = CtySX;
            m.LoaiHang = TenLH;
            m.NamSanXuat = NamSX;
            m.HanSuDung = HanSD;
            if (XuLyMatHang.TaoMatHang(m))
            {
                Ketqua = "Tạo mặt hàng mới thành công";
            } else
            {
                Ketqua = "Tạo thất bại do trùng mã mặt hàng";
            }
        }
    }
}
