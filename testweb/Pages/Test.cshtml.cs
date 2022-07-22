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
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PhanSo() { }
        public PhanSo(int tuso, int mauso)
        {
            TuSo = tuso;
            if (mauso == 0)
            {
                throw new Exception("Mau so phai khac 0");
            } else
            {
                MauSo = mauso;
            }
        }
        public PhanSo Cong(PhanSo P)
        {
            PhanSo T = new PhanSo();
            T.TuSo = this.TuSo * P.MauSo + P.TuSo * this.MauSo;
            T.MauSo = this.MauSo * P.MauSo;
            return T;
        }
        public string Xuat()
        {
            return this.TuSo + "/" + this.MauSo;
        }
    }
    public class XuLyPhanSo : IXuLyPhanSo
    {
        private ILuuTruPhanSo luutru;
        public XuLyPhanSo()
        {
            luutru = new LuuTruPhanSo();
        }
        public List<PhanSo> Doc()
        {
            return luutru.Doc();
        }
        public void Xuat(PhanSo P)
        {
            luutru.Luu(P);
        }
    }
    public interface IXuLyPhanSo
    {
        public List<PhanSo> Doc();
        public void Xuat(PhanSo P);
    }
    public class LuuTruPhanSo : ILuuTruPhanSo
    {
        //data
        //1/2
        //3/4
        public List<PhanSo> Doc()
        {
            try
            {
                StreamReader file = new StreamReader("wwwroot/data/phanso.txt");
                List<PhanSo> DSPS = new List<PhanSo>();
                while (file.EndOfStream == false)
                {
                    string data = file.ReadLine();
                    string[] s = data.Split("/");
                    PhanSo P = new PhanSo(int.Parse(s[0]), int.Parse(s[1]));
                    DSPS.Add(P);
                }
                file.Close();
                if (DSPS.Count == 0)
                {
                    throw new Exception("File du lieu rong");
                }
                return DSPS;
            }
            catch
            {
                throw new Exception("File khong ton tai");
            }
        }
        public void Luu(PhanSo P)
        {
            StreamWriter file = new StreamWriter("wwwroot/data/ketqua.txt");
            file.Write(P.Xuat());
            file.Close();
        }
    }
    public interface ILuuTruPhanSo
    {
        public List<PhanSo> Doc();
        public void Luu(PhanSo P);
    }

    [BindProperties]
    public class TestModel : PageModel
    {
        public string Ketqua;
        public int TuSo1 { get; set; }
        public int MauSo1 { get; set; }
        public int TuSo2 { get; set; }
        public int MauSo2 { get; set; }

        private IXuLyPhanSo xuly;
        public TestModel()
        {
            xuly = new XuLyPhanSo();
        }
        public void OnGet()
        {
            Ketqua= String.Empty;
        }

        public void OnPost()
        {
            try
            {
                //nhập vào 2 phân số -> tinh tổng
                PhanSo P1 = new PhanSo(TuSo1, MauSo1);
                PhanSo P2 = new PhanSo(TuSo2, MauSo2);
                Ketqua = P1.Cong(P2).Xuat();

                //đọc từ file
                //List<PhanSo> DSPS = xuly.Doc();
                //xuly.Xuat(DSPS[0].Cong(DSPS[1])); //xuất kết quả ra file
                //Ketqua = DSPS[0].Cong(DSPS[1]).Xuat(); //xuất kết quả ra màn hình
            }
            catch (Exception ex)
            {
                Ketqua = ex.Message;
            }
        }
    }
}
