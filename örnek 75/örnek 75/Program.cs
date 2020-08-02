using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_75
{
    class Program
    {  
        public class Canli
        {
            public int ayak;
            public int el;
            public string tur;
        }

        public class Insan : Canli
        {
            public void Konus()
            {
                Console.WriteLine("Selam benim {0} adet elim ve {1} adet ayağım var.",el,ayak);
            }            
        }

        public class Kopek : Canli
        {
            public void Havla()
            {
                Console.WriteLine("Hav");
            }
        }
        static void Main(string[] args)
        {
            Insan ins = new Insan();
            Kopek kop = new Kopek();

            ins.el = 2;
            ins.ayak = 2;
            kop.ayak = 4;
            ins.Konus();
            kop.Havla();
            Console.ReadKey();
        }
    }
}
