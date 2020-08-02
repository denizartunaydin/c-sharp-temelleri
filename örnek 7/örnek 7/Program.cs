using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            for (; sayac <= 10; )
                Console.WriteLine(sayac.ToString());
            sayac++;
            Console.ReadKey();
        }
    }
}
