using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 40 arasındaki çift sayıları toplayarak sonucu ekranda gösterelim
  
            int toplam = 0;
            for (int i = 1; i <= 40; i++)
            {
                if (i % 2 == 0)
                    toplam += i;
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
        }
    }
}
