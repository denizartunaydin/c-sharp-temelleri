using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_46
{
    class Program
    {
        static void Yaz(object[] dizi)
        {
            foreach (object i in dizi)
            {
                Console.WriteLine(i);
            }               
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 4, 7, 9 };
            //Hatalı çünkü dizilerde değişkenlerdeki gibi bir bilinçsiz tür dönüşümünden bahsetmek imkansızdır.
            Yaz(dizi);
            Console.ReadKey();
        }
    }
}
