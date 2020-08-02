using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac;
            int toplam;
            string notstr;
            sayac = 0;
            toplam = 0;
            notstr = "";
            while(notstr!="-1")
            {
                sayac++;
                Console.Write("{0}. öğrencinin notu, çıkmak için -1 giriniz:", sayac);
                notstr = Console.ReadLine();
                toplam += Int32.Parse(notstr);
            }
            Console.WriteLine("{0} öğrenci girdiniz", sayac);
            Console.WriteLine("toplam not {0},ortalama{1}", toplam, toplam / sayac);
        }
    }
}
