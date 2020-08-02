using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i = 0;

            // Klavyeden girilecek sayının 0 ile 9999 sınırlarında
            // olup olmadığını kontrol ediliyor. Eğer değilde,
            // uyarı verilip yeni bir sayı isteniyor. Bu işlem 
            // doğru bir değer girilene kadar devam ediyor.

            do
            {
                Console.Write("Sayı giriniz : ");
                sayi = Convert.ToInt16(Console.ReadLine());

                if (sayi > 9999 || sayi < 0)
                    Console.WriteLine("Girdiğiniz sayı 0 ile 9999 arasında olamalıdır");
                else
                    break;
            } while (i == 1);

            Console.WriteLine("{0} sayısı ", sayi);

            // Verilen sayıyı, yazıyla ifade edilmemiz için
            // yüzler , onlar ve birler basamaklarına ayırmamız
            // gerekmektedir.
            // Sayının yüzler basamağı ayrıştırılıyor.
            // Bunun için sayıyı, 100 e bölmek yeterli

            switch(sayi/1000)
            {
                case 9: Console.Write(" dokuzbin "); break;
                case 8: Console.Write(" sekizbin "); break;
                case 7: Console.Write(" yedibin "); break;
                case 6: Console.Write(" altıbin "); break;
                case 5: Console.Write(" beşbin "); break;
                case 4: Console.Write(" dörtbin "); break;
                case 3: Console.Write(" üçbin "); break;
                case 2: Console.Write(" ikibin "); break;
                case 1: Console.Write(" bin "); break;
            }

            switch (sayi % 1000 / 100)
            {
                case 9: Console.Write(" dokuzyüz "); break;
                case 8: Console.Write(" sekizyüz "); break;
                case 7: Console.Write(" yediyüz "); break;
                case 6: Console.Write(" altıyüz "); break;
                case 5: Console.Write(" beşyüz "); break;
                case 4: Console.Write(" dörtyüz "); break;
                case 3: Console.Write(" üçyüz "); break;
                case 2: Console.Write(" ikiyüz "); break;
                case 1: Console.Write(" yüz "); break;
            }

            switch ((sayi % 100) / 10)
            {
                case 9: Console.Write(" doksan "); break;
                case 8: Console.Write(" seksen "); break;
                case 7: Console.Write(" yetmiş "); break;
                case 6: Console.Write(" altmış "); break;
                case 5: Console.Write(" elli "); break;
                case 4: Console.Write(" kırk "); break;
                case 3: Console.Write(" otuz "); break;
                case 2: Console.Write(" yirmi "); break;
                case 1: Console.Write(" on "); break;
            }

            switch ((sayi % 10))
            {
                case 9: Console.Write(" dokuz "); break;
                case 8: Console.Write(" sekiz "); break;
                case 7: Console.Write(" yedi "); break;
                case 6: Console.Write(" altı "); break;
                case 5: Console.Write(" beş "); break;
                case 4: Console.Write(" dört "); break;
                case 3: Console.Write(" üç "); break;
                case 2: Console.Write(" iki "); break;
                case 1: Console.Write(" bir "); break;
            }

            if (sayi == 0)
                Console.WriteLine("sıfır");
            Console.Write(" şeklinde okunur.");

            Console.ReadKey();

        }
    }
}
