using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string yas;
            do
            {
                Console.Write("Yasınızı giriniz , çıkmak için -1 giriniz : ");
                yas = Console.ReadLine();

                if (Int32.Parse(yas) > 50)
                    Console.Write("Yaşlısınız");
                else
                    if (Int32.Parse(yas) >= 20)
                    Console.Write("Genç");
                else
                    if ((Int32.Parse(yas) < 20) && (Int32.Parse(yas) >= 0))
                    Console.Write("Kucuk");
            } while (yas != "-1");
        }
    }
}
