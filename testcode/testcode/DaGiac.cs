//class Program
//{
//    public class Diem
//    {
//        public int X { get; set; }
//        public int Y { get; set; }

//        public void Nhap()
//        {
//            Console.WriteLine("Nhap X: ");
//            X = int.Parse(Console.ReadLine());
//            Console.WriteLine("Nhap Y: ");
//            Y = int.Parse(Console.ReadLine());
//        }
//        public double KhoangCach(Diem D)
//        {
//            return Math.Sqrt((this.X - D.X) * (this.X - D.X) + (this.Y - D.Y) * (this.Y - D.Y));
//        }
//    }
//    public class DaGiac
//    {
//        public List<Diem> DSDinh { get; set; }

//        public void Nhap()
//        {
//            Console.WriteLine("Nhap so dinh: ");
//            int n = int.Parse(Console.ReadLine());
//            List<Diem> DS = new List<Diem>();
//            for (int i = 1; i <= n; i++)
//            {
//                Diem D = new Diem();
//                D.Nhap();
//                DS.Add(D);
//            }
//            DSDinh = DS;
//        }

//        public double TinhChuVi()
//        {
//            double cv = this.DSDinh[DSDinh.Count - 1].KhoangCach(this.DSDinh[0]);
//            for (int i = 1; i < this.DSDinh.Count; i++)
//            {
//                cv += this.DSDinh[i - 1].KhoangCach(this.DSDinh[i]);
//            }
//            return cv;
//        }
//    }
//    static void Main(string[] args)
//    {
//        DaGiac DG = new DaGiac();
//        DG.Nhap();
//        Console.WriteLine(DG.DSDinh[0].X);
//        Console.WriteLine("Chu vi la: " + DG.TinhChuVi());
//        Console.ReadLine();
//    }
//}
