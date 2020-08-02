using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_81
{
    class Program
    {
        class Anne
        {
            public Anne()
            {
                Console.WriteLine("Anne Kurucu");
            }
            public void Selam()
            {
                Console.WriteLine("Anne size 'merhaba' dedi");
            }
            public void Konus()
            {
                Console.WriteLine("Anne konuşuyor");
            }
            public virtual void Sarkı()
            {
                Console.WriteLine("Anne şarkı söylüyor");
            }
        }
        class Cocuk : Anne
        {
            public Cocuk()
            {
                Console.WriteLine("Çocuk Kurucu");
            }
            public new void Konus()
            {
                Console.WriteLine("Çocuk konuşuyor");
            }
            public override void Sarkı()
            {
                Console.WriteLine("Çocuk şarkı söylüyor");
            }
        }
        static void Main(string[] args)
        {
            Anne al = new Anne();
            al.Konus();
            al.Sarkı();
            al.Selam();
            Console.ReadKey();
        }
    }
}
