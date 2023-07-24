using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_çift
{
    class Program
    {
        static void Main(string[] args)
        {
            Double sayi;
            Console.WriteLine("Bir sayı giriniz.");
            sayi = Convert.ToDouble(Console.ReadLine());
            
            if(sayi % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir");
            }
            Console.ReadKey();
        }
    }
}
