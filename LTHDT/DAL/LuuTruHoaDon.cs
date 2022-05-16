using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public abstract class LuuTruHoaDon
    {
        public abstract void LuuHD(Hoadon h);
        public abstract bool XoaID(string id);
    }
}
