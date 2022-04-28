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
    public class MH_SuaModel : PageModel
    {
        public string Ketqua;
        public bool KiemtraID;
        public List<Loaihang> DSLH;

        [BindProperty(SupportsGet =true)]
        public string id { get; set; }
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
            KiemtraID = XuLyMatHang.TimKiemID(id);
            if (KiemtraID)
            {
                TaiLoaiHang();
                Mathang m = XuLyMatHang.LayTTMatHang(id);
                MaMH = m.MaMatHang;
                TenMH = m.TenMatHang;
                CtySX = m.CongTySanXuat;
                TenLH = m.LoaiHang;
                NamSX = m.NamSanXuat;
                HanSD = m.HanSuDung;
            } else
            {
                Ketqua = "Không tìm thấy mã mặt hàng " + id + ". Không thể chỉnh sửa.";
            }
        }

        public void OnPost()
        {
            KiemtraID = XuLyMatHang.TimKiemID(id);
            bool kqSua = XuLyMatHang.SuaMatHang(id, MaMH, TenMH, CtySX, TenLH, NamSX, HanSD);
            TaiLoaiHang();
            if (kqSua)
            {
                Ketqua = "Chỉnh sửa thành công";
                id = MaMH;
            }
            else
            {
                Ketqua = "Chỉnh sửa thất bại, dữ liệu nhập lỗi hoặc bị trùng";
            }
        }
    }
}
