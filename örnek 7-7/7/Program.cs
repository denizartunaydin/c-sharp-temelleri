using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kullanıcı adını giriniz : ");
            string kullanıcı = Console.ReadLine();

            Console.Write("Şifre giriniz : ");
            string sifre = Console.ReadLine();

            /*
            if (kullanıcı == "artun" && sifre == "123")
                Console.Write("Hosgeldin");
            else
                Console.Write("Kullanıcı adı veya şifre yanlış");  
            */

            if (kullanıcı == "artun" && sifre == "123")
                Console.Write("Hosgeldin");
            if (kullanıcı == "artun" && sifre != "123")
                Console.Write("Şifre yanlış");
            if (kullanıcı != "artun" && sifre == "123")
                Console.Write("Kullanıcı adı yanlış");
            if (kullanıcı != "artun" && sifre != "123")
                Console.Write("Kullanıcı adı ve Şifre yanlış");

            Console.ReadKey();


        }
    }
}
