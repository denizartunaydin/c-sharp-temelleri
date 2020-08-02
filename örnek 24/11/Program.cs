using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen sayının faktöriyeli

            Console.Write("Bir sayı giriniz:");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int i = sayi; i > 1; i--)
            {
                sonuc *= i;
            }
            Console.Write("Faktöriyeli:" + sonuc);
            Console.ReadKey();
        }
    }
}
