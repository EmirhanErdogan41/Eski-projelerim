using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_makinesi_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double say1, say2;
            char karakter;
            Console.WriteLine("1. sayıyı giriniz");
            say1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            say2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+,-,*,/)");
            karakter = Convert.ToChar(Console.ReadLine());
            if(karakter == '+')
            {
                Console.WriteLine("{0} + {1} = {2}",say1,say2,say1+say2);
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
            Console.ReadKey();
        }
    }
}
