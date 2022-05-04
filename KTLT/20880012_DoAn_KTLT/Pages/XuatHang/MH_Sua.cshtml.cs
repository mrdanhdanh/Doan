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
        public List<TonkhoMH> DSTKMH;
        public List<PhieuHH> DSBH;

        [BindProperty(SupportsGet = true)]
        public string id { get; set; }
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
        public static List<PhieuHH> LamDayDS(List<PhieuHH> DSBanHang)
        {
            int c = 5 - DSBanHang.Count();
            for (int i=0; i<c; i++)
            {
                PhieuHH hh = new PhieuHH();
                DSBanHang.Add(hh);
            }
            return DSBanHang;
        }
        public void OnGet()
        {
            HDxuat x = XuLyXuat.ThongTinHD(id);
            if (x.MaHD != null)
            {
                TaiTonKho();
                //Nếu trong ds bán có mặt hàng nào không còn tồn kho -> thêm vào DSMH với sl=0 để ko lỗi data
                foreach (PhieuHH hh in x.DSBanHang)
                {
                    var target = DSTKMH.FirstOrDefault(m => m.MaMH == hh.MaMH);
                    if (target == null)
                    {
                        TonkhoMH t = new TonkhoMH();
                        t.MaMH = hh.MaMH;
                        t.SL = 0;
                        DSTKMH.Add(t);
                    }
                }
                DSBH = LamDayDS(x.DSBanHang); //làm đầy ds bằng các sp rỗng để load không lỗi
                MaHD = x.MaHD;
                NgayXuat = x.NgayXuat;
            }
            else
            {
                MaHD = null;
                Ketqua = "Không tìm thấy mã hóa đơn, không thể chỉnh sửa";
            }
            
        }
        public void OnPost()
        {
            HDxuat x = new HDxuat();
            x.MaHD = MaHD;
            x.NgayXuat = NgayXuat;

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
            x.DSBanHang = DSBanHang;
            Ketqua = XuLyXuat.SuaHD(id, x);


            TaiTonKho();
            //Nếu trong ds bán có mặt hàng nào không còn tồn kho -> thêm vào DSMH với sl=0 để ko lỗi data
            foreach (PhieuHH hh in x.DSBanHang)
            {
                var target = DSTKMH.FirstOrDefault(m => m.MaMH == hh.MaMH);
                if (target == null)
                {
                    TonkhoMH t = new TonkhoMH();
                    t.MaMH = hh.MaMH;
                    t.SL = 0;
                    DSTKMH.Add(t);
                }
            }
            DSBH = LamDayDS(x.DSBanHang); //làm đầy ds bằng các sp rỗng để load không lỗi
        }
    }
}
