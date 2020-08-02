using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_64
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Math.Max(10, 34);
            int b = Math.Abs(-3);
            double c = Math.Ceiling(12.67);
            Console.Write("Max:" + a + " Abs" + b + " Ceiling:" + c);
            Console.ReadKey();
        }
    }
}
