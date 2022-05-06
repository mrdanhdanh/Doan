using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20880012_DoAn_KTLT.Entities
{
    public class PhieuHH
    {
        public string MaMH;
        public int Gia;
        public int SoLuong;
    }
    public class HDnhap
    {
        public string MaHD;
        public string NgayNhap;
        public List<PhieuHH> DSNhapHang;
        public int ThanhTien;
    }
}
