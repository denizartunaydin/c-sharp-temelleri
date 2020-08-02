using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullanici_ismi, kullanici_sifresi;
        label:
            Console.Write("\n\nKullanıcı ismini giriniz:\t");
        kullanici_ismi = Console.ReadLine();
        Console.Write("Sifrenizi Giriniz:\t");
        kullanici_sifresi = Console.ReadLine();
            if((kullanici_ismi=="furkan"||kullanici_ismi=="duman")&&(kullanici_sifresi=="1234"))
            {
                Console.WriteLine("\nGiris Basarili.");
            }
            else
            {
                Console.WriteLine("\nYetkisiz Erisim.");
            }
            Console.Write("\n\n Basin E veya e devam etmek icin.:\t");
            char cevap = Convert.ToChar(Console.ReadLine());
            if(cevap=='E'||cevap=='e')
            {
                goto label;
            }
            Console.WriteLine("Cikmak için Enter basiniz...");
            Console.ReadLine();
        }
    }
}
