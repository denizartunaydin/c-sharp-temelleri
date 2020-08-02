using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            a = a + 1;

            a++;        // Yandaki ifadeler
            ++a;        // üstteki a = a + 1 ile
            a += 1;     // aynı işlemi yapar.

            a = a + 5;
            a = a + 14;

            Console.Write(a);
            Console.ReadKey();
        }
    }
}
