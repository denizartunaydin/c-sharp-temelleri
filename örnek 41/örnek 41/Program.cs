using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_41
{
    class Program
    {
        class Metotlar1
        {
            public int Topla(int a, int b)
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            Metotlar1 nesne = new Metotlar1();
            int a = nesne.Topla(3, 9);
            Console.Write(a);
            Console.ReadKey();
        }
    }
}
