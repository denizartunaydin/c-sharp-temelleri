using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_70
{
    class Program
    {
        class EvHalki
        {
            public int DogumYili;
            public string Meslek;
            public string Ad;
            public string GozRengi;
            public int Yas()
            {
                return 2008 - DogumYili;
            }
            public void OzellikleriYaz()
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Adı: " + Ad);
                Console.WriteLine("Yaşı: " + Yas());
                Console.WriteLine("Mesleği: " + Meslek);
                Console.WriteLine("Göz rengi: " + GozRengi);
                Console.WriteLine("---------------");
            }
        }
        static void Main(string[] args)
        {
            EvHalki annem = new EvHalki(); //EvHalki sınıfı türünden yeni bir nesne oluşturuldu.
            annem.DogumYili = 1964; //Oluşturulan nesnenin bir özelliği girildi.
            annem.Meslek = "Ev hanımı";
            annem.Ad = "Hatice";
            annem.GozRengi = "Mavi";
            EvHalki babam = new EvHalki();
            babam.DogumYili = 1950;
            babam.Meslek = "Emekli";
            babam.Ad = "Kenan";
            babam.GozRengi = "Kahverengi";
            EvHalki kardesim = new EvHalki();
            kardesim.DogumYili = 1987;
            kardesim.Meslek = "Öğrenci";
            kardesim.Ad = "Uğur";
            kardesim.GozRengi = "Yeşil";
            annem.OzellikleriYaz();
            babam.OzellikleriYaz();
            kardesim.OzellikleriYaz();
            Console.ReadKey();
        }
    }
}
