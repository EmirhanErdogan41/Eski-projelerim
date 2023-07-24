using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_makinesi3_0
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; )
            {
                double say1, say2;
                char karakter, deger;

                Console.WriteLine("1. sayıyı giriniz");
                say1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("2. sayıyı giriniz");
                say2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+,-,*,/)");
                karakter = Convert.ToChar(Console.ReadLine());

                if (karakter == '+')
                {
                    Console.WriteLine("{0} + {1} = {2}", say1, say2, say1 + say2);
                }
                else if (karakter == '-')
                {
                    Console.WriteLine("{0} - {1} = {2}", say1, say2, say1 - say2);
                }
                else if (karakter == '*')
                {
                    Console.WriteLine("{0} * {1} = {2}", say1, say2, say1 * say2);
                }
                else if (karakter == '/')
                {
                    Console.WriteLine("{0} / {1} = {2}", say1, say2, say1 / say2);
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız.");
                }

                Console.WriteLine("Program sonlandırılsın mı  E/H");
                deger = Convert.ToChar(Console.ReadLine());
                if (deger == 'E' || deger == 'e' )
                {
                    i++;
                }
            }
        }
    }
}
