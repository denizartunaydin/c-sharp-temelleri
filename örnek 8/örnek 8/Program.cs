using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int nSayi = rnd.Next(0,100);
            Console.Write(nSayi);
            while(true)
            {
                Console.WriteLine("Tahmininizi Yapınız.");
                int nTahmin = Convert.ToInt32(Console.ReadLine());
                if (nTahmin > nSayi)
                    Console.WriteLine("daha küçük");
                else if (nTahmin < nSayi)
                    Console.WriteLine("daha büyük");
                else
                {
                    Console.WriteLine("Tebrikler");
                    break;
                }
                System.Console.ReadLine();
            }
        }
    }
}
