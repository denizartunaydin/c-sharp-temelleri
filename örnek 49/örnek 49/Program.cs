using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_49
{
    class Program
    {
        static void Degistir(out int sayi)
        {
            sayi = 10;
        }
        static void Yaz(int sayi)
        {
            Console.WriteLine(sayi);
        }
        static void Main(string[] args)
        {
            /*Kullanımı ref anahtar sözcüğüyle tamamen aynıdır. Tek farkı out ile belirtilen değişkenlere 
            esas programda bir ilk değer verilmesinin zorunlu olmamasıdır.*/
            int sayi;
            Degistir(out sayi);
            Yaz(sayi);
            Console.ReadKey();
        }
    }
}
