using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_65
{
    class Program
    {
        class Sinifismi
        {
            public int ozellik1;
            public string ozellik2;
            public float ozellik3;
            public int metot1(int a, int b)
            {
                return a + b;
            }
            public void metot2(string a)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            Sinifismi nesne = new Sinifismi();
            Console.WriteLine(nesne.ozellik1);
            Console.WriteLine(nesne.ozellik2);
            Console.WriteLine(nesne.ozellik3);
            Console.WriteLine(nesne.metot1(2, 5));
            nesne.metot2("deneme");
            Console.ReadKey();
        }
    }
}
