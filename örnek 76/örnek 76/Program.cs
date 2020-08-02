using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_76
{
    class Program
    {
        class Ucak
        {
            public double Agirlik;
            public double Uzunluk;
            public double Yukseklik;
            public void TeknikBilgiGoster()
            {
                Console.WriteLine("Ağırlık : " + Agirlik);
                Console.WriteLine("Uzunluk : " + Uzunluk);
                Console.WriteLine("Yükseklik : " + Yukseklik);
            }
        }
        class Airbus : Ucak
        {
            public string Model;
            public void ModelGoster()
            {
                Console.WriteLine("Uçak modeli {0}", Model);
            }
        }
        class Boeing : Ucak
        {
            public string Model;
            public void ModelGoster()
            {
                Console.WriteLine("Uçak modeli {0}", Model);
            }
        }
        static void Main(string[] args)
        {
            Airbus A340 = new Airbus();
            A340.Agirlik = 126000;
            A340.Uzunluk = 59.39;
            A340.Yukseklik = 16.74;
            A340.Model = "Airbus A340";
            A340.ModelGoster();
            A340.TeknikBilgiGoster();

            Console.WriteLine("------------------------------");

            Boeing B747 = new Boeing();
            B747.Agirlik = 180985;
            B747.Uzunluk = 70.67;
            B747.Yukseklik = 19.41;
            B747.Model = "Boeing B747";
            B747.ModelGoster();
            B747.TeknikBilgiGoster();

            Console.ReadKey();
        }
    }
}
