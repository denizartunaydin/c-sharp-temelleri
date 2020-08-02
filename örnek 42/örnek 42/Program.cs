using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_42
{
    class Program
    {
        static void Yaz(object a, int b)
        {
            for (; b > 0; b--)
                Console.Write(a);
        }
        static void Main(string[] args)
        {
            Yaz("deneme\n", 3);
            Console.ReadKey();
        }
    }
}
