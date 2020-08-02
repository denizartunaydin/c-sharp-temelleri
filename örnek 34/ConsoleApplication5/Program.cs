using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[6] { 12, 10, 256, 23, 900, 568 };
            int[] dizi1 = new int[6];

            dizi1 = dizi;

            foreach (var i in dizi1)
            {
                Console.WriteLine(dizi1[3]);                
            }

            Console.ReadKey();
        }
    }
}
