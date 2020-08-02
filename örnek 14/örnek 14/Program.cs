using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string yas;
            do
            {
                Console.Write("Yasinizi Giriniz, cikmak icin -1 giriniz");
                yas = Console.ReadLine();
                if (Int32.Parse(yas) > 50)
                    Console.WriteLine("Yaslisiniz");
                else if (Int32.Parse(yas) >= 20)
                    Console.WriteLine("Gencsiniz");
                else if ((Int32.Parse(yas) < 20) && (Int32.Parse(yas) >= 0))
                    Console.WriteLine("Kucuksunuz");
            } while (yas != "-1");
        }
    }
}
