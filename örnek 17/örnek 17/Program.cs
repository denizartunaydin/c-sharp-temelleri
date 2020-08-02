using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;
            int toplam;
            string notstr;
            sayac = 1;
            toplam = 0;
            Console.Write("1.Öğrencinin notunuz giriniz:");
            notstr = Console.ReadLine();
            toplam = Int32.Parse(notstr);
            while(++sayac<10)
            {
                Console.Write("{0}. öğrencinin notunu giriniz:", sayac);
                notstr = Console.ReadLine();
                toplam += Int32.Parse(notstr);
            }
            sayac--;
            Console.WriteLine("{0} öğrenci girdiniz", sayac);
            Console.WriteLine("toplam not {0}", toplam);
        }
    }
}
