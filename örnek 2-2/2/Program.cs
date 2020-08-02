using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 20;

            Console.WriteLine("a = " + a + " b = " + b);
            Console.WriteLine("a = {0} b = {1} ", a, b);
            Console.WriteLine("a = {0} b = {1}  c = {2}", a, b, c);
            Console.WriteLine("a = {0} b = {1}  a + c = {2}", a, b, a + c);

            // {0} {1} gibi ifadeler devamında (,) ile gelen ve sıfırdan başlayan
            // bir sıra numarası verilmiş ise değişkenlerin çift tırnak içersinde
            // nasıl yerleşim yapacağını belirler

            Console.ReadKey();
        }
    }
}
