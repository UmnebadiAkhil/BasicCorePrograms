﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenAndOdd
    {
        public static void EvenOdd()
        {
            Console.WriteLine("Enter the number to Check");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is an Even number", num);
            }
            else
            {
                Console.WriteLine("{0} is an Odd number", num);
            }
        }
    }
}
