using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0;i<20;i++)
            {
                if (i == 15)
                    break;
                if (i % 2 == 0)
                    continue;
                Console.Write("{0}", i);
                Console.WriteLine();
                Console.ReadLine();
            }
            
        }
    }
}
