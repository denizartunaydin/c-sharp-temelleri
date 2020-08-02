using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_50
{
    class Program
    {
        static void Metot1(int x, int y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }
        static void Metot1(float x, float y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }
        static void Metot1(string x, string y)
        {
            Console.WriteLine("3. metot çağrıldı.");
        }
        static void Main(string[] args)
        {
            Metot1("deneme", "deneme");
            Metot1(5, 6);
            Metot1(10f, 56f);
            Console.ReadKey();
        }
    }
}
