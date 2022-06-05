using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace testcode
{
  
    class Program
    {
        public class PhanSo
        {
            public int TUSO { get; set; }
            public int MAUSO { get; set; }
            public PhanSo() { }
            public PhanSo(int tuso, int mauso)
            {
                TUSO = tuso;
                MAUSO = mauso;
            }
            public void Nhap()
            {
                Console.WriteLine("Nhap Tu So: ");
                TUSO = int.Parse(Console.ReadLine());
                MAUSO = 0;
                while (MAUSO == 0)
                {
                    Console.WriteLine("Nhap Mau So: ");
                    MAUSO = int.Parse(Console.ReadLine());
                }
            }
            public PhanSo LonHon(PhanSo P)
            {
                double a = (double)this.TUSO / this.MAUSO;
                double b = (double)P.TUSO / P.MAUSO;
                if (a>b)
                {
                    return this;
                } else
                {
                    return P;
                }
            }
            public void Xuat()
            {
                //Các cách xuất 1 chuỗi ra màn hình
                Console.WriteLine(this.TUSO + "/" + this.MAUSO);
                Console.WriteLine($"{this.TUSO}/{this.MAUSO}");
                Console.WriteLine("{0}/{1}", this.TUSO, this.MAUSO);
                Console.ReadLine();
            }
        }
        public class XuLyPhanSo : IXuLyPhanSo
        {
            private ILuuTruPhanSo luutru;
            public XuLyPhanSo()
            {
                luutru = new LuuTruPhanSo();
            }
            public List<PhanSo> NhapMangPS()
            {
                List<PhanSo> DSPS = new List<PhanSo>();
                Console.WriteLine("Nhap so luong PS: ");
                int n = int.Parse(Console.ReadLine());
                for (int i=1; i <= n; i++)
                {
                    PhanSo P = new PhanSo();
                    P.Nhap();
                    DSPS.Add(P);

                }
                return DSPS;
            }
            public PhanSo TimPSLonNhat(List<PhanSo> DSPS)
            {
                PhanSo Max = DSPS[0];
                for (int i = 1; i < DSPS.Count; i++)
                {
                    Max = Max.LonHon(DSPS[i]);
                }
                return Max;
            }
            public void Luu(PhanSo P)
            {
                luutru.LuuPS(P);
            }
        }
        public class LuuTruPhanSo : ILuuTruPhanSo
        {
            //data: 1/2
            public PhanSo DocPS()
            {
                StreamReader file = new StreamReader("D:/phanso.txt");
                string data = file.ReadToEnd();
                file.Close();
                string[] s = data.Split("/");
                PhanSo P = new PhanSo(int.Parse(s[0]), int.Parse(s[1]));
                return P;
            }
            public void LuuPS(PhanSo P)
            {
                StreamWriter file = new StreamWriter("D:/phanso.txt");
                file.Write(P.TUSO + "/" + P.MAUSO);
                file.Close();
            }

            //data dạng xuống dòng
            //1/2
            //5/6
            //3/4
            public List<PhanSo> DocDSPStype1()
            {
                StreamReader file = new StreamReader("D:/phanso.txt");
                List<PhanSo> DSPS = new List<PhanSo>();
                while (file.EndOfStream == false) {
                    string data = file.ReadLine();
                    string[] s = data.Split("/");
                    PhanSo P = new PhanSo(int.Parse(s[0]), int.Parse(s[1]));
                    DSPS.Add(P);
                }
                file.Close();
                return DSPS;
            }
            public void LuuDSPStype1(List<PhanSo> DSPS)
            {
                StreamWriter file = new StreamWriter("D:/phanso.txt");
                foreach (PhanSo P in DSPS)
                {
                    file.WriteLine(P.TUSO + "/" + P.MAUSO);
                }
                file.Close();
            }

            //data dạng Json: using Newtonsoft.Json;
            //[{"TUSO":1,"MAUSO":2},{"TUSO":5,"MAUSO":6},{"TUSO":3,"MAUSO":4}]
            public List<PhanSo> DocDSPStype2()

            {
                StreamReader file = new StreamReader("D:/phanso.txt");
                string data = file.ReadToEnd();
                List<PhanSo> DSPS = JsonConvert.DeserializeObject<List<PhanSo>>(data);
                file.Close();
                return DSPS;
            }
            public void LuuDSPStype2(List<PhanSo> DSPS)
            {
                StreamWriter file = new StreamWriter("D:/phanso.txt");
                string data = JsonConvert.SerializeObject(DSPS);
                file.Write(data);
                file.Close();
            }
        }
        public interface IXuLyPhanSo
        {
            public List<PhanSo> NhapMangPS();
            public PhanSo TimPSLonNhat(List<PhanSo> DSPS);
            public void Luu(PhanSo P);
        }
        public interface ILuuTruPhanSo
        {
            public PhanSo DocPS();
            public void LuuPS(PhanSo P);

            public List<PhanSo> DocDSPStype1();
            public void LuuDSPStype1(List<PhanSo> DSPS);
            public List<PhanSo> DocDSPStype2();
            public void LuuDSPStype2(List<PhanSo> DSPS);
        }
        static void Main(string[] args)
        {
            IXuLyPhanSo xuly = new XuLyPhanSo();
            List<PhanSo> DSPS = xuly.NhapMangPS();
            PhanSo Max = xuly.TimPSLonNhat(DSPS);
            xuly.Luu(Max);
        }
    }
}
