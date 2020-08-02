using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            sayi1 = 15;
            sayi2 = 5;
            sayi1 += sayi2;
            Console.WriteLine("Topla={0}", sayi1);
            sayi1 -= sayi2;
            Console.WriteLine("\n\n Çıkar={0}", sayi1);
            sayi1 *= sayi2;
            Console.WriteLine("\n\n Çarp={0}", sayi1);
            sayi1%=sayi2;
            Console.WriteLine("\n\n Mod={0}",sayi1);
            Console.ReadLine();
        }
    }
}
