using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using Newtonsoft.Json;

namespace testweb.Pages
{
    public struct SanPham
    {
        public string TenSP;
        public int Gia;
        public int NamSX;
    }
    public class XuLySanPham
    {
        public static List<SanPham> TimKiem(string keyword)
        {
            List<SanPham> DSSPfull = LuuTruSanPham.DocSanPham();
            if (keyword == null)
            {
                return DSSPfull;
            } else
            {
                List<SanPham> DSSP = new List<SanPham>();
                foreach (SanPham s in DSSPfull)
                {
                    if (s.TenSP.Contains(keyword))
                    {
                        DSSP.Add(s);
                    }
                }
                if (DSSP.Count > 0)
                {
                    return DSSP;
                } else
                {
                    throw new Exception("Khong tim thay san pham");
                }
            }
        }
    }
    public class LuuTruSanPham
    {
        public static List<SanPham> DocSanPham()
        {
            StreamReader file = new StreamReader("wwwroot/data/sanpham.json");
            string jsonString = file.ReadToEnd();
            file.Close();
            List<SanPham> dssanpham = JsonConvert.DeserializeObject<List<SanPham>>(jsonString);
            return dssanpham;
        }
    }
    public class TestModel : PageModel
    {
        public string Thongbao;
        public List<SanPham> DSSP;
        [BindProperty]
        public string KeyWord { get; set; }

        public void OnGet()
        {
            Thongbao = String.Empty;
            DSSP = new List<SanPham>();
        }

        public void OnPost()
        {
            try
            {
                DSSP = XuLySanPham.TimKiem(KeyWord);
            }
            catch (Exception ex)
            {
                Thongbao = ex.Message;
            }
        }
    }
}
