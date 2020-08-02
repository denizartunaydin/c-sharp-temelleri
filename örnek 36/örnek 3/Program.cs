using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace örnek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ogrsay, i, secim;

            Console.WriteLine("Kaç öğrenci gireceksiniz : ");

            ogrsay = Int32.Parse(Console.ReadLine());

            int[,] dizi = new int[ogrsay + 1, 3];

            for (i = 1; i < ogrsay; i++)
            {
                Console.WriteLine("{0}. Öğrencinin vize notu : ", i);
                dizi[i, 0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0}. Öğrencinin final notu : ", i);
                dizi[i, 1] = Int32.Parse(Console.ReadLine());
                dizi[i, 1] = (dizi[i, 0] + dizi[i, 1]) / 2;
            }

            Console.WriteLine("{0} öğrencinin kaçıncısının not ortalamasını öğrenmek istiyorsunuz...", ogrsay);
            secim = Int32.Parse(Console.ReadLine());
            Console.Write("{0}. öğrencinin ortalaması : {1}\n", secim, dizi[secim, 2]);
            Console.ReadKey();
        }
    }
}
