using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_21
{
    class Program
    {
        static void Main(string[] args)
        {
            float s;
            int si, f;
            bool a = true;
            for(;a;)
            {
                Console.Write("Lütfen faktoriyelinin alınmasını istediğiniz sayıyı girin:");
                s = Convert.ToSingle(Console.ReadLine());
                si = (int)s;
                if (si != s || s < 1)
                {
                    Console.WriteLine("Lütfen pozitip tam sayı girin.");
                    a = true;
                }
                else
                {
                    a = false;
                    for (f = 1; si > 1; si--)
                        f *= si;
                    Console.Write("Faktöriyeli={0}", f);
                    Console.ReadLine();
                }
                }
        }
  }
    }
