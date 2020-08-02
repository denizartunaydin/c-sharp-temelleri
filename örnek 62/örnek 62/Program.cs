using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_62
{
    class Program
    {
        static float Fonksiyon(float x)
        {
            return 3 * x + 6;
        }
        static float TersFonksiyon(float x)
        {
            return (x - 6) / 2;
        }
        static void Main(string[] args)
        {
            float x = 15;
            Console.WriteLine(Fonksiyon(x));
            Console.WriteLine(TersFonksiyon(x));
            Console.WriteLine(Fonksiyon(TersFonksiyon(x)));
            Console.ReadKey();
        }
    }
}
