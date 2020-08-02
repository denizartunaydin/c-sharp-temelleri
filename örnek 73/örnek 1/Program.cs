using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_1
{
    class Program
    {
        class Class1
        {
            public int kareAl(int x)
            {
                return x * x;
            }
            public double kareAl(double x)
            {
                return x * x;
            }
        }        
        
        static void Main(string[] args)
        {
            Class1 myClass = new Class1();
            Console.WriteLine(myClass.kareAl(15.1));
            Console.ReadKey();  
            
        }
    }
}
