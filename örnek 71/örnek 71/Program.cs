using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_71
{
    class Program
    {
        public int en;
        public int Boy;
        void EnBoyBelirle(int en, int boy)
        {
            this.en = en;
            Boy = boy;
        }
        static void Main(string[] args)
        {
            Program d1 = new Program();
            d1.EnBoyBelirle(20, 50);
            Console.WriteLine(d1.en + "\n" + d1.Boy);
            Console.ReadKey();
        }
    }
}
