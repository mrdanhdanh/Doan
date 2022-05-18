using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace _20880012_DoAn_LTHDT.Pages.NhapHang
{
    public class MH_SuaModel : PageModel
    {
        public string Ketqua;
        public bool KiemTra = false;
        public IXuLyMatHang xulyMH;
        public IXuLyHoaDon xulyHD;
        public List<Mathang> DSMH;
        public List<PhieuHH> DSHH = new List<PhieuHH>();

        [BindProperty]
        public string MaHD { get; set; }
        [BindProperty]
        public string NgayTao { get; set; }
        [BindProperty]
        public int DemSP { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }

        public MH_SuaModel()
        {
            xulyMH = new XuLyMatHang();
            xulyHD = new XuLyNhap();
        }
        public void OnGet()
        {
            try
            {
                var kq = xulyMH.TimKiemMatHang(null);
                KiemTra = kq.IsSuccess;
                DSMH = kq.Data;
                if (KiemTra)
                {
                    var taihd = xulyHD.ThongTinHD(ID);
                    MaHD = taihd.Data.MaHD;
                    NgayTao = taihd.Data.NgayTao;
                    DSHH = taihd.Data.DShanghoa;
                    DemSP = DSHH.Count;
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
                for (int i = 0; i < DemSP; i++)
                {
                    var mamh = "mamh" + i;
                    var gia = "gia" + i;
                    var sl = "sl" + i;
                    PhieuHH hh = new PhieuHH(Request.Form[mamh], int.Parse(Request.Form[gia]), int.Parse(Request.Form[sl]));
                    DSHH.Add(hh);
                }
                HDnhap h = new HDnhap();
                h.TaoHoadon(MaHD, NgayTao, DSHH);
                var kq = xulyHD.SuaHD(ID, h);
                Ketqua = kq.Message;
                KiemTra = kq.IsSuccess;
                DSMH = xulyMH.TimKiemMatHang(null).Data;
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
    }
}
