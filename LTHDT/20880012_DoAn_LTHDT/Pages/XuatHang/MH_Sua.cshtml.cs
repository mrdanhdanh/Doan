using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages.XuatHang
{
    public class MH_SuaModel : PageModel
    {
        public string Ketqua;

        public bool KiemTra = false;
        public IXuLyTonKho xulyTK;
        public IXuLyHoaDon xulyHD;
        public List<TonkhoMH> DSTK;
        public Hoadon h;

        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }
        [BindProperty]
        public string MaHD { get; set; }
        [BindProperty]
        public string NgayTao { get; set; }
        [BindProperty]
        public int DemSP { get; set; }

        public MH_SuaModel()
        {
            xulyTK = new XuLyTonKho();
            xulyHD = new XuLyXuat();
        }
        public void OnGet()
        {
            try
            {
                var kq = xulyTK.TaoTonKhoMH();
                KiemTra = kq.IsSuccess;
                DSTK = kq.Data;
                Ketqua = kq.Message;
                if (KiemTra)
                {
                    var Info = xulyHD.ThongTinHD(ID);
                    KiemTra = Info.IsSuccess;
                    h = Info.Data;
                    Ketqua = Info.Message;
                    DemSP = h.DShanghoa.Count;
                    DSTK = xulyTK.BoSungTonKho(DSTK, h.DShanghoa); //Bổ sung DSTK những sp có tồn kho = 0
                }
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
        public void OnPost()
        {
            try
            {
                List<PhieuHH> DSHH = new List<PhieuHH>();
                for (int i = 0; i < DemSP; i++)
                {
                    var mamh = "mamh" + i;
                    var gia = "gia" + i;
                    var sl = "sl" + i;
                    PhieuHH hh = new PhieuHH(Request.Form[mamh], int.Parse(Request.Form[gia]), int.Parse(Request.Form[sl]));
                    DSHH.Add(hh);
                }
                HDxuat hd = new HDxuat();
                hd.TaoHoadon(MaHD, NgayTao, DSHH);

                var kq = xulyHD.SuaHD(ID, hd);
                Ketqua = kq.Message;
                KiemTra = kq.IsSuccess;
                h = kq.Data;
                DSTK = xulyTK.TaoTonKhoMH().Data;
                DSTK = xulyTK.BoSungTonKho(DSTK, h.DShanghoa);
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }

        }
    }
}
