using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double not1, not2, ort;           
            Console.WriteLine("1, notunuzu giriniz");
            not1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2,  notunuzu giriniz");
            not2 = Convert.ToDouble(Console.ReadLine());
            ort = (not1 + not2) / 2;
            Console.WriteLine("Ortalamanız = {0}",ort);
            if (ort >= 50)
                {
                 Console.WriteLine("Sınıfı geçtiniz ortalamanız");
                }
            else
                {
                 Console.WriteLine("Sınıfta kaldınız ");
                }
            Console.ReadKey();
        }
    }
}
