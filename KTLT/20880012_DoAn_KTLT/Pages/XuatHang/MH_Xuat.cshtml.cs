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
    public class MH_XuatModel : PageModel
    {
        public string Ketqua;
        public List<Mathang> DSMH = XuLyMatHang.TimKiemMatHang(null);
        public List<TonkhoMH> DSTKMH;

        public string MaHD { get; set; }
        public string NgayXuat { get; set; }

        public string MaMH0 { get; set; }
        public int Gia0 { get; set; }
        public int SL0 { get; set; }
        public string MaMH1 { get; set; }
        public int Gia1 { get; set; }
        public int SL1 { get; set; }
        public string MaMH2 { get; set; }
        public int Gia2 { get; set; }
        public int SL2 { get; set; }
        public string MaMH3 { get; set; }
        public int Gia3 { get; set; }
        public int SL3 { get; set; }
        public string MaMH4 { get; set; }
        public int Gia4 { get; set; }
        public int SL4 { get; set; }

        public void TaiTonKho()
        {
            DSTKMH = XuLyTonKho.TaiDSTonKhoMH(null);
            if (DSTKMH.Count() == 0)
            {
                Ketqua = "Kho không còn hàng để bán, vui lòng nhập hàng trước khi xuất hóa đơn bán";
            }
        }
        public void OnGet()
        {
            TaiTonKho();
        }
        public void OnPost()
        {
            HDxuat h = new HDxuat();
            h.MaHD = MaHD;
            h.NgayXuat = NgayXuat;


            string[] MaMH = { MaMH0, MaMH1, MaMH2, MaMH3, MaMH4 };
            int[] Gia = { Gia0, Gia1, Gia2, Gia3, Gia4 };
            int[] SL = { SL0, SL1, SL2, SL3, SL4 };
            List<PhieuHH> DSBanHang = new List<PhieuHH>();
            for (int i = 0; i < 5; i++)
            {
                PhieuHH HangBan = new PhieuHH();
                HangBan.MaMH = MaMH[i];
                HangBan.Gia = Gia[i];
                HangBan.SoLuong = SL[i];
                DSBanHang.Add(HangBan);
            }
            h.DSBanHang = DSBanHang;
            Ketqua = XuLyXuat.XuatHD(h);
            TaiTonKho();
        }
    }
}
