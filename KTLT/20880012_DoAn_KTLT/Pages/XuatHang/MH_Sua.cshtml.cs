using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using _20880012_DoAn_KTLT.Entities;
using _20880012_DoAn_KTLT.Services;

namespace _20880012_DoAn_KTLT.Pages.XuatHang
{
    [BindProperties]
    public class MH_SuaModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH = XuLyMatHang.TimKiemMatHang(null);
        public List<Tonkho> DSTK;

        public string MatHang;

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
        public string MaHD { get; set; }
        public string NgayXuat { get; set; }
        public string MaMH { get; set; }
        public int SL { get; set; }

        public void TaiTonKho()
        {
            DSTK = XuLyTonKho.TaiDSTonKho(null);
            if (DSTK.Count() == 0)
            {
                Ketqua = "Kho không còn hàng để bán, vui lòng nhập hàng trước khi xuất hóa đơn bán";
            }
        }
        public void OnGet()
        {
            HDxuat x = XuLyXuat.ThongTinHD(id);
            if (x.MaHD != null)
            {
                TaiTonKho();
                var target = DSTK.FirstOrDefault(hd => hd.MaMH == x.MaMH);
                if (target == null)
                {
                    Tonkho t = new Tonkho();
                    t.MaMH = x.MaMH;
                    t.SL = 0;
                    DSTK.Add(t);
                }
                MaHD = x.MaHD;
                NgayXuat = x.NgayXuat;
                SL = x.SoLuong;
                MaMH = x.MaMH;

            } else
            {
                MaHD = null;
                Ketqua = "Không tìm thấy mã hóa đơn, không thể chỉnh sửa";
            }
            
        }
        public void OnPost()
        {
            Ketqua = XuLyXuat.SuaHD(id, MaHD, NgayXuat, MaMH, SL);
            TaiTonKho();
            var target = DSTK.FirstOrDefault(hd => hd.MaMH == MaMH);
            if (target == null)
            {
                Tonkho t = new Tonkho();
                t.MaMH = MaMH;
                t.SL = 0;
                DSTK.Add(t);
            }
        }
    }
}
