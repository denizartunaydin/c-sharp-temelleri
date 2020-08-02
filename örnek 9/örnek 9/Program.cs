using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;
            int topla, cikar, carp;
            float bol;
            Console.Write("Birinci Sayiyi Giriniz\t\t");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\nİkinci Sayiyi Giriniz\t\t");
                sayi2=Convert.ToInt32(Console.ReadLine());
                topla = sayi1 + sayi2;
                cikar = sayi1 - sayi2;
                carp = sayi1 * sayi2;
                bol = (float)sayi1 / sayi2;
                //Cikti
                Console.WriteLine("\n\n=====================\n");
                Console.WriteLine("Toplama\t\t{0}", topla);
                Console.WriteLine("Cikarma\t\t{0}", cikar);
                Console.WriteLine("Carpma\t\t{0}", carp);
                Console.WriteLine("Bolme\t\t{0}", bol);
                Console.WriteLine("\n=======================\n");
                Console.ReadLine();
        }
    }
}
