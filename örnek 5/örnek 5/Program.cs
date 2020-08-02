using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNot = -1;
            while (nNot != 0)
            {
                Console.WriteLine("Notunuzu Giriniz.");
                nNot = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Harf notunuz:");
                if (nNot >= 90)
                    Console.WriteLine("A");
                else if (nNot >= 80)
                    Console.WriteLine("B");
                else if (nNot >= 70)
                    Console.WriteLine("C");
                else if (nNot >= 60)
                    Console.WriteLine("D");
                else
                    Console.WriteLine("F");
            }
            System.Console.ReadLine();
        }
    }
}
