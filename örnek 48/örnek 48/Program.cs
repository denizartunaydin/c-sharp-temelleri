using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_48
{
    class Program
    {
        static void Degistir(ref int sayi)
        {
            sayi = 10;
        }
        static void Yaz(int sayi)
        {
            Console.WriteLine(sayi);
        }
        static void Main(string[] args)
        {
            int sayi = 1;
            Degistir(ref sayi);
            Yaz(sayi);
            Console.ReadKey();
        }
    }
}
