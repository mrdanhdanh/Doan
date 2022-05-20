using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DAL;

namespace Services
{
    public class XuLyTonKho : IXuLyTonKho
    {
        public IXuLyHoaDon xulyNhap;
        public IXuLyHoaDon xulyXuat;
        public IXuLyMatHang xulyMH;
        public IXuLyLoaiHang xulyLH;

        public XuLyTonKho()
        {
            xulyXuat = new XuLyXuat();
            xulyNhap = new XuLyNhap();
            xulyMH = new XuLyMatHang();
            xulyLH = new XuLyLoaiHang();
        }

        public ServiceResult<List<TonkhoMH>> TaoTonKhoMH()
        {
            List<Mathang> DSMH = xulyMH.TimKiemMatHang(null).Data;
            List<TonkhoMH> DSTK = new List<TonkhoMH>();
            List<Hoadon> DSHD = xulyNhap.TimKiemHD(null, null).Data;
            DSHD.AddRange(xulyXuat.TimKiemHD(null, null).Data);
            bool isNhap;
            foreach (Mathang m in DSMH)
            {
                TonkhoMH t = new TonkhoMH(m);
                DSTK.Add(t);
            }

            foreach (Hoadon h in DSHD)
            {
                if (h.LoaiHD() == "Nhap")
                {
                    isNhap = true;
                } else
                {
                    isNhap = false;
                }
                foreach (PhieuHH hh in h.DShanghoa)
                {
                    foreach (TonkhoMH t in DSTK)
                    {
                        t.SuaTonKho(hh, isNhap);
                    }
                }
            }
            for (int i=0; i<DSTK.Count; i++)
            {
                if (DSTK[i].KiemTraTK() == false)
                {
                    DSTK.RemoveAt(i);
                }
            }
            if (DSTK.Count == 0)
            {
                return new ServiceResult<List<TonkhoMH>>(false, null, "Không có tồn kho, vui lòng nhập hàng");
            } else
            {
                return new ServiceResult<List<TonkhoMH>>(true, DSTK, null);
            }
        }
    }
}
