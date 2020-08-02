using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_43
{
    class Program
    {
        static void Yaz(object a, int b)
        {
            if (b > 10)
                return;
            for (; b > 0; b--)
                Console.Write(a);
        }
        static void Main(string[] args)
        {
            Yaz('m'+ "\n", 10);
            Console.ReadKey();
        }
    }
}
