using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace örnek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, tasiyici, secim, adet, skont;
            Console.WriteLine("Kaç adet sayı gireceksini:");
            adet=Convert.ToInt32(Console.ReadLine());
            int[]dizi=new int[adet +1];
            for(i=1;i<=adet;i++)
            {
                Console.WriteLine("sayı giriniz");
                dizi[i] = Int32.Parse(Console.ReadLine());
            }
            for (i = 1; i <=adet; i++)
            {
                for (j=i+1;j<=adet;j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        tasiyici = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = tasiyici;
                    }
                }
            }

            Console.Write("büyükten küçüğe sıralamak için 1e\nküçükten büyüğe sıralamak için 2 ye\n basınız\n seçim:");
            do
            {
                secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                skont = 2;
                if (secim==1)
                {
                    Console.WriteLine("büyükten küçüğe sıralama\n");
                    skont = 1;
                    for (i = 1; i <= adet;i++ )
                    {
                        Console.WriteLine("{0}", dizi[i]);

                    }
                    
                }
                else if (secim == 2)
                {
                    Console.WriteLine("küçükten büyüğe sıralama\n");
                    skont = 1;
                    for (i = adet; i >= 1; i--)
                    {
                        Console.WriteLine("{0}", dizi[i]);
                    }
                } else { Console.WriteLine("yanlış seçim yaptınız"); }                
            } while (skont==2);
            Console.ReadKey();			
        }
    }
}
