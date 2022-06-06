using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace testcode
{
  
    class Program
    {
        public abstract class SinhVien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public double DiemTB { get; set; }
            public void Nhap()
            {
                Console.WriteLine("Nhap ma sinh vien: ");
                MaSV = Console.ReadLine();
                Console.WriteLine("Nhap ten sinh vien: ");
                TenSV = Console.ReadLine();
                Console.WriteLine("Nhap diem trung binh: ");
                DiemTB = double.Parse(Console.ReadLine());
            }
            public abstract int TinhHocBong();
        }
        public class ChinhQuy : SinhVien
        {
            public override int TinhHocBong()
            {
                if (this.DiemTB >= 9.0)
                {
                    return 1500000;
                } else if (this.DiemTB >= 8.0)
                {
                    return 1000000;
                } else
                {
                    return 0;
                }
            }
        }
        public class TaiNang : SinhVien
        {
            public override int TinhHocBong()
            {
                if (this.DiemTB >= 9.0)
                {
                    return 2000000;
                }
                else if (this.DiemTB >= 8.0)
                {
                    return 1500000;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class ChatLuongCao : SinhVien
        {
            public override int TinhHocBong()
            {
                if (this.DiemTB >= 9.0)
                {
                    return 2500000;
                }
                else if (this.DiemTB >= 8.0)
                {
                    return 2000000;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class XuLySinhVien : IXuLySinhVien
        {
            public List<SinhVien> NhapSV()
            {
                Console.WriteLine("Nhap so luong sinh vien: ");
                int n = int.Parse(Console.ReadLine());
                List<SinhVien> DSSV = new List<SinhVien>();
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Nhap he dao tao cua sinh vien (0: chinh quuy, 1: tai nang, 2: chat luong cao): ");
                    int l = int.Parse(Console.ReadLine());
                    switch (l)
                    {
                        case 0:
                            SinhVien cq = new ChinhQuy();
                            cq.Nhap();
                            DSSV.Add(cq);
                            break;
                        case 1:
                            SinhVien tn = new TaiNang();
                            tn.Nhap();
                            DSSV.Add(tn);
                            break;
                        case 2:
                            SinhVien clc = new ChatLuongCao();
                            clc.Nhap();
                            DSSV.Add(clc);
                            break;
                        default:
                            break;
                    }
                }
                return DSSV;
            }
            public int TongHB(List<SinhVien> DSSV)
            {
                int t = 0;
                foreach (SinhVien s in DSSV)
                {
                    t += s.TinhHocBong();
                }
                return t;
            }
        }
        public interface IXuLySinhVien
        {
            public List<SinhVien> NhapSV();
            public int TongHB(List<SinhVien> DSSV);
        }
        static void Main(string[] args)
        {
            IXuLySinhVien xuly = new XuLySinhVien();
            List<SinhVien> DSSV = xuly.NhapSV();
            Console.WriteLine("Tong tien hoc bong la: " + xuly.TongHB(DSSV));
            Console.ReadLine();
        }
    }
}
