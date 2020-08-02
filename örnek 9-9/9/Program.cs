using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b;
            Console.Write("1 sayıyı giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("2 sayıyı giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());
            
            string secim;
            Console.WriteLine("(1) Toplama");
            Console.WriteLine("(2) Çıkarma");
            Console.WriteLine("(3) Çarpma");
            Console.WriteLine("(4) Bölme");
            Console.Write("Seçiminiz : ");
            secim = Console.ReadLine();
            switch (secim)
            {
                case "1": Console.Write("Toplam = {0}", a + b);
                    break;
                case "2": Console.Write("Çıkarma = {0}", a + b);
                    break;
                case "3": Console.Write("Çarpma = {0}", a + b);
                    break;
                case "4": Console.Write("Bölme = {0}", a + b);
                    break;
                default: Console.Write("Geçersiz işlem seçildi");                    
                    break;
                    
            }
            
            Console.ReadKey();
        }
    }
}
