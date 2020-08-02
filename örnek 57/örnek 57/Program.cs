using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_57
{
    class Program
    {
        static void Metot1(int x, int y)
        {
            Console.WriteLine("1. metot çağrıldı.");
        }
        static void Metot1(int x, params int[] y)
        {
            Console.WriteLine("2. metot çağrıldı.");
        }
        static void Main(string[] args)
        {
            Metot1(4, 9, 10);
            Console.ReadKey();
        }
    }
}
