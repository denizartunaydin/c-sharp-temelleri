using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_47
{
    class Program
    {
        static void Degistir(int[] dizi)
        {
            for (int i = 0; i < 5; i++)
            {
                dizi[i] = 10;
            }                
        }
        static void Yaz(Array dizi)
        {
            foreach (object a in dizi)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 4, 7, 8 };
            Degistir(dizi);
            Yaz(dizi);
            Console.ReadKey();
        }
    }
}
