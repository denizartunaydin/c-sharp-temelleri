using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_53
{
    class Program
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }
        static void Metot1(int x, int y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }
        static void Main(string[] args)
        {
            //Bu durumda ikinci metot çağrılır. Çünkü char hem inte hem de floata bilinçsiz olarak dönüşebilir. Ancak int daha az kapasitelidir.
            Metot1('f', 'g');
            Console.ReadKey();
        }
    }
}
