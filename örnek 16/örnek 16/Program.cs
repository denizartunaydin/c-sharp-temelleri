using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i=0, sonuc;
            a = 1;
            sonuc = 0;
            while (a<=10)
            {
                sonuc = a * i;
                Console.WriteLine(a + "x" + i + "=" + sonuc);
                i++;
            }
            Console.WriteLine("---------------");
            a++;
            {
                Console.ReadLine();
            }
        }
    }
}
