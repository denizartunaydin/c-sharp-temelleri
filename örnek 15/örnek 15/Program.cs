﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while(number<5)
            {
                Console.WriteLine(number);
                number = number + 1;
            }
            Console.ReadLine();
        }
    }
}
