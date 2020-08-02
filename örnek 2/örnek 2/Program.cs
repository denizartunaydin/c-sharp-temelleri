using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 18;
            bool paraVar = false;
            bool kartVar = true;
            double susuzluk = 0.31;
            bool haftaIci = false;
            bool sonuc = yas >= 18 && (paraVar || kartVar) && susuzluk > 0.3 && !haftaIci;
            Console.WriteLine("{0}", sonuc);
            System.Console.ReadLine();
        }
    }
}
