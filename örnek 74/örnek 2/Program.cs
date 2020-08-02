using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_2
{
    class Class1
    {
        public int kareAl(int x)
        {
            Console.Write("1.metod\n");
            return x * x;
        }
        public double kareAl(double x)
        {
            Console.Write("2.metod\n");
            return x * x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myclass = new Class1();
            Console.Write(myclass.kareAl(15.1));
            Console.ReadKey();
        }
    }
}
