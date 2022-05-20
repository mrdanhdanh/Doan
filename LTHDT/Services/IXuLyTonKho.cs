using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLyTonKho
    {
        ServiceResult<List<TonkhoMH>> TaoTonKhoMH();
    }
}
