using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_45
{
    class Program
    {
        static void Yaz(Array dizi)
        {
            foreach (object i in dizi)
            {
                Console.WriteLine(i);
            }                
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 4, 7, 9 };
            Yaz(dizi);
            Console.ReadKey();
        }
    }
}
