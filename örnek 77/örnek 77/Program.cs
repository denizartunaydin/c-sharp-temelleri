using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_77
{
    class Program
    {
        class Ucak
        {
            private double Agirlik;

            public double Agirlik1
            {
                get { return Agirlik; }
                set { Agirlik = value; }
            }

            private double Uzunluk;
            public double Uzunluk1
            {
                get { return Uzunluk; }
                set { Uzunluk = value; }
            }
            private double Yukseklik;
            public double Yukseklik1
            {
                get { return Yukseklik; }
                set { Yukseklik = value; }
            }
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
            A340.Agirlik1 = 126000;
            A340.Uzunluk1 = 59.39;
            A340.Yukseklik1 = 16.74;
            A340.Model = "Airbus A340";
            A340.ModelGoster();
            A340.TeknikBilgiGoster();

            Console.WriteLine("------------------------------");

            Boeing B747 = new Boeing();
            B747.Agirlik1 = 180985;
            B747.Uzunluk1 = 70.67;
            B747.Yukseklik1 = 19.41;
            B747.Model = "Boeing B747";
            B747.ModelGoster();
            B747.TeknikBilgiGoster();

            Console.ReadKey();
        }
    }
}
