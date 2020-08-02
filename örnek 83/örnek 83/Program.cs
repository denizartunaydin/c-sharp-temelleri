﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_83
{
    class Program
    {
        class A
        {
            public void Metot()
            {
                Console.WriteLine("A sınıfı");
            }
        }
        class B : A
        {
            public void Metot()
            {
                Console.WriteLine("B sınıfı");
            }
        }
        static void Main(string[] args)
        {
            A nesneA = new A();
            B nesneB = new B();
            nesneA = nesneB;
            nesneA.Metot();
            Console.ReadKey();
        }
    }
}
