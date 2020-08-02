using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Herhangi bir sayı giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());

            if (a < 0)
                Console.Write("Negatif");
            else
                Console.Write("Pozitif");

            Console.ReadKey();

            // Koşul her zaman parantez içinde belirtilmelidir.
            // else ifadesi if ile belirtilen 
            // koşulun gerçekleşmediği her durumu değerlendirmek
            // için kullanılan bir komuttur.
        }
    }
}
