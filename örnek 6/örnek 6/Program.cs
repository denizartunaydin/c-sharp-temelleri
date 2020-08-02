using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNot = -1;
            do
            {
                Console.WriteLine("Notunuzu giriniz.");
                nNot = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Harf Notunuz:");
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
            } while (nNot != 0);
            System.Console.ReadLine();
        }
    }
}
