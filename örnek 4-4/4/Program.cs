using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;
            Console.Write("İsim giriniz : ");
            isim = Console.ReadLine();

            if (isim == "artun")
                Console.Write("Doğru");
            else
                Console.Write("Yanlış");

            Console.ReadKey();
        }
    }
}
