using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class VowelOfAlphabet
    {
        public static void Alphabet()
        {
            Console.WriteLine("Enter an Alphabet :");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("{0} is a vowel", letter);
            }
            else
            {
                Console.WriteLine("{0} is a Consonant", letter);
            }
        }
    }
}
