using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_sayının_denkliği
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            try
                {
                Console.WriteLine("1. sayıyı giriniz");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2, sayıyı giriniz");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                if(sayi1>sayi2)
                    {
                    Console.WriteLine("Büyük olan sayi = {0}",sayi1);
                    }
                else if(sayi2>sayi1)
                    {
                    Console.WriteLine("Büyük olan sayı = {0}",sayi2);
                    }
                else
                    {
                    Console.WriteLine("Sayılar eşittir");
                    }
                }
            catch
                {
                Console.WriteLine("Hatalı veri girişi yaptınız");
                }
            Console.ReadKey();
        }
    }
}
