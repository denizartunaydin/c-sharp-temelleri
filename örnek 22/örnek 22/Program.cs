using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (y = 0; y < 9; y++)
            {
                for (x = 9; x > y; x--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                Console.ReadLine();
            }
        }
    }
}
