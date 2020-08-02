using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[6] { 12, 10, 216, 23, 900, 568 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.ReadKey();
        }
    }
}
