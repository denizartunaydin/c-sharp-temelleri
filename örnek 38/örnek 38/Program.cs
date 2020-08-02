using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_38
{
    class Program
    {
        int Topla(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Program nesne = new Program();
            int a = nesne.Topla(2, 5);
            Console.Write(a);
            Console.ReadKey();
        }
    }
}
