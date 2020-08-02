using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_72
{
    class Program
    {
        class YardimciSinif
        {
            int Sayi;
            public void SayiBelirle(int sayi)
            {
                Sayi = sayi;
            }
            public int SayiAl()
            {
                return Sayi;
            }
        }
        static void Main(string[] args)
        {
            YardimciSinif nesne = new YardimciSinif();
            nesne.SayiBelirle(34);
            Console.WriteLine(nesne.SayiAl());
            Console.ReadKey();
        }
    }
}
