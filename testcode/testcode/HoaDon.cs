//class Program
//{
//    public abstract class HangHoa
//    {
//        public int DonGia { get; set; }
//        public int SoLuong { get; set; }
//        public abstract double ThanhTien();
//    }
//    public class HangBT : HangHoa
//    {
//        public HangBT(int dongia, int sl)
//        {
//            DonGia = dongia;
//            SoLuong = sl;
//        }
//        public override double ThanhTien()
//        {
//            return (this.DonGia * this.SoLuong * 1.1);
//        }
//    }
//    public class HangDB : HangHoa
//    {
//        public HangDB(int dongia, int sl)
//        {
//            DonGia = dongia;
//            SoLuong = sl;
//        }
//        public override double ThanhTien()
//        {
//            return (this.DonGia * this.SoLuong * 1.15);
//        }
//    }
//    public class HoaDon
//    {
//        public string MaHD { get; set; }
//        public string NguoiMua { get; set; }
//        public string NgayLap { get; set; }
//        public List<HangHoa> DSHangHoa { get; set; }
//        public void Nhap()
//        {
//            Console.WriteLine("Nhap Ma HD: ");
//            MaHD = Console.ReadLine();
//            Console.WriteLine("Nhap Nguoi mua: ");
//            NguoiMua = Console.ReadLine();
//            Console.WriteLine("Nhap Ngay Lap: ");
//            NgayLap = Console.ReadLine();
//            Console.WriteLine("Nhap So luong hang hoa: ");
//            int n = int.Parse(Console.ReadLine());
//            List<HangHoa> DS = new List<HangHoa>();
//            for (int i = 1; i <= n; i++)
//            {
//                Console.WriteLine($"Nhap loai hang thu {i} (0: loai thuong; 1: dac biet):");
//                int l = int.Parse(Console.ReadLine());
//                Console.WriteLine("Don gia: ");
//                int dg = int.Parse(Console.ReadLine());
//                Console.WriteLine("So Luong: ");
//                int sl = int.Parse(Console.ReadLine());
//                switch (l)
//                {
//                    case 0:
//                        HangHoa ht = new HangBT(dg, sl);
//                        DS.Add(ht);
//                        break;
//                    case 1:
//                        HangHoa hd = new HangDB(dg, sl);
//                        DS.Add(hd);
//                        break;
//                    default:
//                        break;
//                }
//            }
//            DSHangHoa = DS;
//        }
//        public double TongTien()
//        {
//            double t = 0;
//            foreach (HangHoa h in this.DSHangHoa)
//            {
//                t += h.ThanhTien();
//            }
//            return t;
//        }
//    }
//    static void Main(string[] args)
//    {
//        HoaDon h = new HoaDon();
//        h.Nhap();
//        Console.WriteLine("Tong Tien là: " + h.TongTien());
//        Console.ReadLine();
//    }
//}