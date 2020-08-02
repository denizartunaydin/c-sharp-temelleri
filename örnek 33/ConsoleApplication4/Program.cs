using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[6] { 12, 10, 256, 23, 900, 568 };
            int[] dizi1 = new int[6];

            for (int i = 0; i < 6; i++)
            {
                dizi1[i] = dizi[i];
                Console.WriteLine(dizi[i]);
            }

            dizi1[0] = 25;

            foreach (var i in dizi1)
            {
                Console.WriteLine(i);
                
            }

            Console.ReadKey();
        }
    }
}
