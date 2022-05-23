using System;
using System.Linq;
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

        public List<TonkhoMH> BoSungTonKho(List<TonkhoMH> DSTK, List<PhieuHH> DSHH)
        {
            List<Mathang> DSMH = xulyMH.TimKiemMatHang(null).Data;
            foreach (PhieuHH hh in DSHH)
            {
                var target = DSTK.FirstOrDefault(t => t.MaMH == hh.MaMH);
                if (target == null)
                {
                    var mh = DSMH.FirstOrDefault(m => m.MaMatHang == hh.MaMH);
                    if (mh != null)
                    {
                        TonkhoMH t = new TonkhoMH(mh);
                        DSTK.Add(t);
                    } else
                    {
                        throw new Exception("Có lỗi bất thường ở dữ liệu mặt hàng, vui lòng kiểm tra và thử lại");
                    }
                }
            }
            return DSTK;
        }
        public List<TonkhoMH> LocTonKhoMH(List<TonkhoMH> DSTK, string mamh, string odate)
        {
            List<TonkhoMH> DSloc = new List<TonkhoMH>();

            foreach (TonkhoMH t in DSTK)
            {
                if (mamh == null || t.MaMH == mamh)
                {
                    if (odate == "on")
                    {
                        if (t.OutDate)
                        {
                            DSloc.Add(t);
                        }
                    } else
                    {
                        DSloc.Add(t);
                    }
                }
            }

            return DSloc;
        }

        public ServiceResult<List<TonkhoLH>> TaiTonKhoLH(string keyword)
        {
            List<TonkhoMH> TKMH = TaoTonKhoMH().Data;
            List<Loaihang> DSLH = xulyLH.TimKiemLoaiHang(null);
            List<TonkhoLH> TKLH = new List<TonkhoLH>();
            if (keyword == null)
            {
                keyword = String.Empty;
            }
            foreach (Loaihang l in DSLH)
            {
                if (l.TenLoaiHang.Contains(keyword))
                {
                    TonkhoLH t = new TonkhoLH();
                    t.TenLH = l.TenLoaiHang;
                    t.TonKho = 0;
                    foreach (TonkhoMH m in TKMH)
                    {
                        if (m.TenLH == t.TenLH)
                        {
                            t.TonKho += m.TonKho;
                        }
                    }
                    TKLH.Add(t);
                }
            }
            if (TKLH.Count > 0)
            {
                return new ServiceResult<List<TonkhoLH>>(true, TKLH, null);
            }
            else
            {
                return new ServiceResult<List<TonkhoLH>>(false, null, "Không tìm thấy loại hàng");
            }

        }
    }
}
