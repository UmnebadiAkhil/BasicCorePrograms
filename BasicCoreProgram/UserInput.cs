using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    class UserInput
    {
        public static void InputName()
        {
            string? name = null;
            Console.WriteLine("Please the Enter Name ");
            name = Console.ReadLine();

            int namelength = name.Length;

            if (namelength >= 3 )
            {
                Console.WriteLine("Hello " + name + " How are you?");
                Console.WriteLine("The Length of string " + namelength);
            }

        }
    }
}
