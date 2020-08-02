using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayi = 0, i = 3;
            for(;i<1001;i+=3)
            {
                if (i % 15 == 0)
                    continue;
                //break;
                sayi++;
                toplam += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("sayısı:" + sayi);
            Console.WriteLine("Toplam:" + toplam);
            Console.ReadLine();
        }
    }
}
