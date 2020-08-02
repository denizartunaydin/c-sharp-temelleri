using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_80
{
    class Program
    {
        public class Cizici
        {
            public virtual void Ciz()
            {
                Console.WriteLine("Çizici");
            }
        }

        public class DogruCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Line");
            }
        }

        public class DaireCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Daire");
            }
        }

        public class KareCiz : Cizici
        {
            public override void Ciz()
            {
                Console.WriteLine("Kare");
            }
        }       

        static void Main(string[] args)
        {
            Cizici[] birCizici = new Cizici[4];
            birCizici[0] = new DogruCiz();
            birCizici[1] = new DaireCiz();
            birCizici[2] = new KareCiz();
            birCizici[3] = new Cizici();

            foreach (Cizici sayac in birCizici)
            {
                sayac.Ciz();
            }
            Console.ReadKey();
        }

    }
}
