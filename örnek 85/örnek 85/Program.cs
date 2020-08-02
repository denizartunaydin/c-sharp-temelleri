using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_85
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
        class B : A 
        {
            public override void Metot()
            {
                Console.WriteLine("B sınıfı");
            }
        }
        class C : B
        {
            public void Metot()
            {
                Console.WriteLine("C sınıfı");
            }
        }
        static void Main(string[] args)
        {
            A nesneA = new A();
            C nesneC = new C();
            nesneA = nesneC;
            nesneA.Metot();
            Console.ReadKey();
        }
    }
}
