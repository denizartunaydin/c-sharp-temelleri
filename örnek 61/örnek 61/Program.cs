using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_61
{
    class Program
    {
        static int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;
            return a * Faktoriyel(a - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Faktoriyel(0));
            Console.WriteLine(Faktoriyel(1));
            Console.WriteLine(Faktoriyel(4));
            Console.WriteLine(Faktoriyel(6));
            Console.ReadKey();
        }
    }
}
