using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim, sifre;
            isim = "furkan";
            sifre = "furkan1234";
            if (isim=="furkan"&& sifre=="furkan1234")
            {
                Console.WriteLine("Giris Basarili");
            }
            else
            {
                Console.WriteLine("Yetkisiz Erisim");
            }
            Console.ReadLine();
        }
    }
}
