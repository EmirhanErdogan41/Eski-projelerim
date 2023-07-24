using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_değeri
{
    class Program
    {
        static void Main(string[] args)
        {
            int giris;
            Console.WriteLine("Bir karakter giriniz");
            giris = Console.Read();
            Console.WriteLine("ASCII kod karşılığı = {0}", giris);
            Console.ReadKey();
        }
    }
}
