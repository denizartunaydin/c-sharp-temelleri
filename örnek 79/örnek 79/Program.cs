
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_79
{
    class Program
    {
        public class AtaSınıf
        {
            public AtaSınıf()
            {
                Console.WriteLine("Ata Kurucu");
            }

            public void Yaz()
            {
                Console.WriteLine("Ben Ata sınıfındayım");
            }
        }
        public class OgulSınıf : AtaSınıf
        {
            public OgulSınıf()
            {
                Console.WriteLine("Oğul kurucu");
            }
        }
        static void Main(string[] args)
        {
            OgulSınıf ogul = new OgulSınıf();
            ogul.Yaz();
            Console.ReadKey();
        }
    }
}
