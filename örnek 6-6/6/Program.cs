using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            menu:

            Console.WriteLine("(1) Dikdörtgen alanı");
            Console.WriteLine("(2) Çıkış");
            Console.Write("Seçim : ");

            byte secim = Convert.ToByte(Console.ReadLine());

            if (secim == 1)
            {
                Console.Write("Kısa kenar giriniz : ");
                byte a = Convert.ToByte(Console.ReadLine());

                Console.Write("Uzun kenar giriniz : ");
                byte b = Convert.ToByte(Console.ReadLine());

                Console.WriteLine("Dikdörtgenini alanı = {0} ", a * b);
                Console.ReadLine();
                Console.Clear();
                goto menu;
            }
            else
            {
                if (secim == 2)

                    return;

                else

                    Console.Clear();
                Console.WriteLine("!!!! Yanlış seçim");
                goto menu;
            }

            goto menu;

            Console.ReadKey();
                     
            

           
        }
    }
}
