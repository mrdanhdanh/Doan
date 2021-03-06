using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLyTonKho
    {
        ServiceResult<List<TonkhoMH>> TaoTonKhoMH();
        List<TonkhoMH> BoSungTonKho(List<TonkhoMH> DSTK, List<PhieuHH> DSHH);
        List<TonkhoMH> LocTonKhoMH(List<TonkhoMH> DSTK, string mamh, string odate);
        ServiceResult<List<TonkhoLH>> TaiTonKhoLH(string keyword);
        
    }
}
