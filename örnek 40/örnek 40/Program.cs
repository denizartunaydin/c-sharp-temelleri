using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_40
{
    class Program
    {
        class Metotlar1
        {
            public static int Topla(int a, int b)
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            int a = Metotlar1.Topla(2, 5);
            Console.Write(a);
            Console.ReadKey();
        }
    }
}
