using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_78
{
    class Program
    {
        class Personel
        {
            public string adi, soyadi;
        }

        class akademikPersonel : Personel
        {
            public string unvan, mail;
        }
        static void Main(string[] args)
        {
            akademikPersonel kisi = new akademikPersonel();
            kisi.adi = "Artun";
            kisi.soyadi = "Aydın";
            kisi.unvan = "Yazılımcı";
            kisi.mail = "aydnartun@gmail.com";
            Console.ReadKey();
        }
    }
}
