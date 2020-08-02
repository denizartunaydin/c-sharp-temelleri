using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[6] { 12, 10, 256, 23, 900, 568 };
            int[] dizi1 = new int[6];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi1[i] = dizi[i];
                Console.WriteLine(dizi[i]);
            }

            Console.ReadKey();
        }
    }
}
