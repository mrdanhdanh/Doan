using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace testcode
{
  
    class Program
    {
        public class SanPham
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int Gia { get; set; }
            public string NhanHang { get; set; }
            public string HanSD { get; set; }
            public string NgaySX { get; set; }

            public void Nhap()
            {
                Console.WriteLine("Nhap Ma SP: ");
                MaSP = Console.ReadLine();
                Console.WriteLine("Nhap ten SP: ");
                TenSP = Console.ReadLine();
                Console.WriteLine("Nhap Gia: ");
                Gia = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Nhan hang: ");
                NhanHang = Console.ReadLine();
                Console.WriteLine("Nhap han su dung: ");
                HanSD = Console.ReadLine();
                Console.WriteLine("Nhap ngay san xuat: ");
                NgaySX = Console.ReadLine();
            }
            public bool HetHan()
            {
                DateTime dn = DateTime.Now;
                DateTime d = DateTime.Parse(this.HanSD);
                if (d.CompareTo(dn) > 0)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
        }
        public class XuLySanPham : IXuLySanPham
        {
            public List<SanPham> NhapSP()
            {
                List<SanPham> SP = new List<SanPham>();
                Console.WriteLine("Nhap so luong sp: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i<=n; i++)
                {
                    SanPham s = new SanPham();
                    s.Nhap();
                    SP.Add(s);
                }
                return SP;
            }
            public void TimSPHetHang(List<SanPham> SP)
            {
                Console.WriteLine("Cac sp het han la: ");
                bool check = false;
                foreach (SanPham s in SP)
                {
                    if (s.HetHan())
                    {
                        Console.Write(s.MaSP + " ");
                        check = true;
                    }
                }
                if(check == false) {
                    Console.Write("Khong co");
                }
            }
        }
        public interface IXuLySanPham
        {
            public List<SanPham> NhapSP();
            public void TimSPHetHang(List<SanPham> SP);
        }
        static void Main(string[] args)
        {
            IXuLySanPham xuly = new XuLySanPham();
            List<SanPham> SP = xuly.NhapSP();
            xuly.TimSPHetHang(SP);
            Console.ReadLine();
        }
    }
}
