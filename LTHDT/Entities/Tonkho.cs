using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class TonkhoMH
    {
        public string MaMH;
        public string TenMH;
        public string TenLH;
        public int TonKho;
        public bool OutDate;

        public TonkhoMH() { }
        public TonkhoMH(Mathang m)
        {
            MaMH = m.MaMatHang;
            TenMH = m.TenMatHang;
            TenLH = m.TenLoaiHang;
            TonKho = 0;
            OutDate = KiemTraHetHan(m.HanSuDung);
        }
        private bool KiemTraHetHan(string date)
        {
            DateTime n = DateTime.Now;
            DateTime hsd = DateTime.Parse(date);
            if (DateTime.Compare(n, hsd) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SuaTonKho (PhieuHH hh, bool isNhap)
        {
            if (this.MaMH == hh.MaMH)
            {
                if (isNhap)
                {
                    this.TonKho += hh.SoLuong;
                } else
                {
                    this.TonKho -= hh.SoLuong;
                }
            }
        }
        public bool KiemTraTK()
        {
            if (this.TonKho >0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    public class TonkhoLH
    {
        public string TenLH { get; set; }
        public int TonKho { get; set; }
    }
}
