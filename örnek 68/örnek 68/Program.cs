using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_68
{
    class Program
    {
        class KrediHesabi
        {
            public ulong HesapNo;
        }
        static void Main(string[] args)
        {
            KrediHesabi hesap1 = new KrediHesabi();
            KrediHesabi hesap2 = hesap1;
            hesap1.HesapNo = 3456;
            hesap2.HesapNo = 1212;
            Console.WriteLine(hesap1.HesapNo);
            Console.WriteLine(hesap2.HesapNo);
            Console.ReadKey();
        }
    }
}
