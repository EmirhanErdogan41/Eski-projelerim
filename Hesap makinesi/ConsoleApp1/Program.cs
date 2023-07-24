using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sayi1, sayi2;
                char simge;
                double sonuc;
                Console.WriteLine("1. SAYI");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. SAYI");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yaptırmak istediğiniz işlemin sembolünü giriniz. (+,-,*,/)");
                simge = Convert.ToChar(Console.ReadLine());
                if(simge=='+')
                    {
                    sonuc = sayi1 + sayi2;                 
                    }
                else if(simge=='-')
                    {
                    sonuc = sayi1 - sayi2;                 
                    }
                else if(simge=='*')
                    {
                    sonuc = sayi1 * sayi2;          
                    }
                else
                    {
                    sonuc = sayi1 / sayi2;    
                    }

                Console.WriteLine(sonuc);
            }
            catch
            {
                Console.WriteLine("Hatalı giriş yaptınız");
            }
            Console.ReadKey();
        }
    }
}
