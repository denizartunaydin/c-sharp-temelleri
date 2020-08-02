using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1 ile 100 arasında sayı üretelim, üretilen sayı 50 olana kadar sayıları ekrana yazdıran 

            Random r = new Random();
            int sayi;
            do
            {
                sayi = r.Next(1, 101);
                Console.Write("{0} ", sayi); // sayi+" " 
            }
            while (sayi != 50);
            //sayi 50 den farklı olduğu sürecek döngü devam eder. 
            Console.ReadKey();
        }
    }
}
