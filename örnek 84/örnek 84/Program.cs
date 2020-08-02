using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_84
{
    class Program
    {
        class A
        {
            virtual public void Metot()
            {
                Console.WriteLine("A sınıfı");
            }
        }

        class B:A
        {
            override public void Metot()
            {
                Console.WriteLine("B sınıfı");
            }
        }

        static void Main(string[] args)
        {
            A nesneA = new A();
            B nesneB = new B();
            nesneA = nesneB;
            nesneA.Metot();
            Console.ReadKey();
        }
    }
}
