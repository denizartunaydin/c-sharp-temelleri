using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;
            sayac = 10;
           /* while (--sayac > 0)
                Console.WriteLine(sayac);*/
            for (sayac = 1; sayac < 10; sayac++)
                Console.WriteLine(sayac);
            /*for(;;)//sonsuz döngü*/
            Console.ReadLine();
        }
    }
}
