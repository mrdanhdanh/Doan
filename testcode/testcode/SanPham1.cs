//class Program
//{
//    public abstract class SanPham
//    {
//        public int Gia { get; set; }
//        public virtual void Nhap()
//        {
//            Console.WriteLine("Nhap gia san pham: ");
//            Gia = int.Parse(Console.ReadLine());
//        }
//        public abstract double TinhThue();
//    }
//    public class NoiDia : SanPham
//    {
//        public override void Nhap()
//        {
//            base.Nhap();
//        }
//        public override double TinhThue()
//        {
//            return (double)Gia * 0.15;
//        }
//    }
//    public class NhapKhau : SanPham
//    {
//        public int ThueNK { get; set; }
//        public int ThueTTDB { get; set; }
//        public override void Nhap()
//        {
//            base.Nhap();
//            Console.WriteLine("Nhap thue Nhap Khau: ");
//            ThueNK = int.Parse(Console.ReadLine());
//            Console.WriteLine("Nhap thue Tieu thu Dac Biet: ");
//            ThueTTDB = int.Parse(Console.ReadLine());
//        }
//        public override double TinhThue()
//        {
//            double Thue = (double)(10 + ThueNK + ThueTTDB) / 100;
//            return Gia * Thue;
//        }
//    }
//    public class XuLySanPham : IXuLySanPham
//    {
//        public List<SanPham> NhapSP()
//        {
//            Console.WriteLine("Nhap so luong sp: ");
//            int n = int.Parse(Console.ReadLine());
//            if (n > 0)
//            {
//                List<SanPham> DSSP = new List<SanPham>();
//                for (int i = 1; i <= n; i++)
//                {
//                    Console.WriteLine("Nhap loai sp (0: Noi Dia; 1: Nhap Khau): ");
//                    int l = int.Parse(Console.ReadLine());
//                    switch (l)
//                    {
//                        case 0:
//                            SanPham nd = new NoiDia();
//                            nd.Nhap();
//                            DSSP.Add(nd);
//                            break;
//                        case 1:
//                            SanPham nk = new NhapKhau();
//                            nk.Nhap();
//                            DSSP.Add(nk);
//                            break;
//                        default:
//                            break;
//                    }
//                }
//                return DSSP;
//            }
//            else
//            {
//                throw new Exception("n phai lon hon 0");
//            }
//        }
//        public double TongThue(List<SanPham> DSSP)
//        {
//            double t = 0;
//            foreach (SanPham s in DSSP)
//            {
//                t += s.TinhThue();
//            }
//            return t;
//        }
//    }
//    public interface IXuLySanPham
//    {
//        public List<SanPham> NhapSP();
//        public double TongThue(List<SanPham> DSSP);
//    }
//    static void Main(string[] args)
//    {
//        try
//        {
//            IXuLySanPham xuly = new XuLySanPham();
//            List<SanPham> DSSP = xuly.NhapSP();
//            Console.WriteLine("Tong thue la: " + xuly.TongThue(DSSP));
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//        }
//        Console.ReadLine();
//    }
//}
