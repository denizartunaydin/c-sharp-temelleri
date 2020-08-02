using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim, sifre;

            Console.WriteLine("İsim giriniz : ");
            isim = Console.ReadLine();

            Console.Write("Şifre giriniz : ");
            sifre = Console.ReadLine();

            if (isim == "artun")
                if (sifre == "123")                
                    Console.Write("Hoş geldin");                
                else
                    Console.Write("Şifre yanlış");
            else
                Console.Write("İsim yanlış");

            Console.ReadKey();

        }
    }
}
