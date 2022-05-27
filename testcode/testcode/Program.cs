using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace testcode
{
    public struct PhanSo
    {
        public int TuSo;
        public int MauSo;
    }

    class Program
    {
        public static PhanSo TaoPhanSo(int tuso, int mauso)
        {
            PhanSo P;
            P.TuSo = tuso;
            if (mauso != 0)
            {
                P.MauSo = mauso;
            } else
            {
                while (mauso == 0)
                {
                    Console.Write("Vui long nhap lai mau so: ");
                    mauso = int.Parse(Console.ReadLine());
                }
                P.MauSo = mauso;
            }
            return P;
        }
        public static PhanSo TinhTong(PhanSo A, PhanSo B)
        {
            var mauso = A.MauSo * B.MauSo;
            var tuso = A.MauSo * B.TuSo + B.MauSo * A.TuSo;
            return TaoPhanSo(tuso, mauso);
        }
        public static void XuatPhanSo(PhanSo P)
        {
            Console.WriteLine("{0}/{1}", P.TuSo, P.MauSo);
        }
        public static void Luu(PhanSo P)
        {
            StreamWriter file = new StreamWriter("D:\\phanso.txt");
            file.Write("{0}/{1}", P.TuSo, P.MauSo);
            file.Close();
        }
        public static List<PhanSo> Doc()
        {
            List<PhanSo> L = new List<PhanSo>();
            StreamReader file = new StreamReader("D:\\phanso.txt");
            while (file.EndOfStream == false)
            {
                string data = file.ReadLine();
                string[] s = data.Split("/");
                PhanSo P = TaoPhanSo(int.Parse(s[0]), int.Parse(s[1]));
                L.Add(P);
            }
            file.Close();
            return L;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap Phan So 1: - Tu So: ");
            //int tuso = int.Parse(Console.ReadLine());
            //Console.WriteLine("- Mau So: ");
            //int mauso = int.Parse(Console.ReadLine());
            //PhanSo A = TaoPhanSo(tuso, mauso);
            //Console.WriteLine("Nhap Phan So 2: - Tu So: ");
            //tuso = int.Parse(Console.ReadLine());
            //Console.WriteLine("- Mau So: ");
            //mauso = int.Parse(Console.ReadLine());
            //PhanSo B = TaoPhanSo(tuso, mauso);
            //List<PhanSo> L = Doc();

            //Console.WriteLine("Tong 2 phan so la : ");
            //XuatPhanSo(TinhTong(L[0],L[1]));
            Console.WriteLine(1 / 2);
            Console.ReadLine();
        }
    }
}
