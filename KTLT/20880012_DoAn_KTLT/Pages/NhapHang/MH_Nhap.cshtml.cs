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


            string[] MaMH = { MaMH0, MaMH1, MaMH2, MaMH3, MaMH4 };
            int[] Gia = { Gia0, Gia1, Gia2, Gia3, Gia4 };
            int[] SL = { SL0, SL1, SL2, SL3, SL4 };
            List<PhieuHH> DSNhapHang = new List<PhieuHH>();
            for (int i=0; i<5; i++)
            {
                PhieuHH HangNhap = new PhieuHH();
                HangNhap.MaMH = MaMH[i];
                HangNhap.Gia = Gia[i];
                HangNhap.SoLuong = SL[i];
                DSNhapHang.Add(HangNhap);
            }
            h.DSNhapHang = DSNhapHang;

            Ketqua = XuLyNhap.NhapHD(h);
        }
    }
}
