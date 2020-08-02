using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dairenin alanı pi*r*r    // Dairenin çevresi 2 * pi * r

            Console.Write("Yarıçapı giriniz : ");
            int r = Convert.ToInt16(Console.ReadLine());

            double dairenin_alani = 3 * r * r;
            double dairenin_cevresi = 2 * 3 * r;

            Console.WriteLine("Dairenin Çevresi = " + dairenin_cevresi);
            Console.Write("Dairenin Alanı = " + dairenin_alani);

            Console.ReadKey();


        }
    }
}
