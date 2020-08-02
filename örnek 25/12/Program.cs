using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            // O ile 100 arasındaki tek sayıları toplayarak sonucu ekranda gösteren program

        
            int sayi = 0;
            int toplam = 0;
            while (sayi <= 100)
            {
                if (sayi % 2 == 1)
                    toplam += sayi;
                sayi++;
            }
            Console.WriteLine("Tek sayıların toplamı:" + toplam);
            Console.ReadKey();
        }
    }
}
