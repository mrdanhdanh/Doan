using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class HDnhap : Hoadon
    {
        public HDnhap() { }

        public override void TaoHoadon(string mahd, string ngaytao, List<PhieuHH> dshanghoa)
        {
            base.TaoHoadon(mahd, ngaytao, dshanghoa);
        }

        public override string LoaiHD()
        {
            return "Nhap";
        }
    }
    
}
