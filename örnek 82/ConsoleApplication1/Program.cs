using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Base 
    {
        public virtual void Yaz1()
        {
            Console.WriteLine("Yaz1 base olan sınıftan, virtual olarak geldim");
        }

        public virtual void Yaz2()
        {
            Console.WriteLine("Yaz2 base olan sınıftan, virtual olarak geldim");
        }

        public void Yaz()
        {
            this.Yaz1();
            this.Yaz2();
        }
    }
    class Print : Base
    {
        public override void Yaz1()
        {
            Console.WriteLine("derived olan sınıftan, override olarak geldim");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Print prt = new Print();
            prt.Yaz();
            Console.ReadKey();
        }
    }
}