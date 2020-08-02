using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Notunuzu giriniz.");
            String sNot = Console.ReadLine();
            switch(sNot)
            {
                case "A":
                    Console.WriteLine("Çok güzel");
                    break;
                case"B":
                    Console.WriteLine("Güzel");
                    break;
                case"C":
                    Console.WriteLine("Fena Değil");
                    break;
                case"D":
                    Console.WriteLine("İyi Değil");
                    break;
                case"F":
                    Console.WriteLine("Çok kötü");
                    break;
                default:
                    Console.WriteLine("Geçersiz harf notu");
                    break;
            }
            System.Console.ReadLine();
        }
    }
}
