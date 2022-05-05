using System;
using System.Globalization;

namespace testcode
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            string da = "2022-05-05";
            DateTime t = DateTime.Parse(da);
            Console.WriteLine(DateTime.Compare(d,t));
        }
    }
}
