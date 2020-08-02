using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace örnek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sonuc;
            int[] dizi = new int[11];
            int[] dizi2 = new int[11];
            for (i = 1; i <= 10; i++)
            {
                dizi[i] = dizi2[i] = i;
            }
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    sonuc = dizi[i] * dizi2[j];
                    Console.WriteLine("{0} * {1} = {2}", dizi[i], dizi2[j], sonuc);
                    Console.WriteLine("");
                }
            }

            Console.ReadKey();

               
        }
    }
}
