using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_55
{
    class Program
    {
        static int Toplam(params int[] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            int toplam = 0;
            foreach (int i in sayilar)
                toplam += i;
            return toplam;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Toplam());
            Console.WriteLine(Toplam(5));
            Console.WriteLine(Toplam(5, 10));
            Console.WriteLine(Toplam(2, 9, 12));
            Console.WriteLine(Toplam(7, 12, 45));
            Console.WriteLine(Toplam(123, 12, 5, 7, 9, 4, 12));
            Console.ReadKey();
        }
    }
}
