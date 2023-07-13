using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter a Alphabet ");
            char input = Convert.ToChar(Console.ReadLine());
            input = Char.ToLower(input);
            if(input.Equals('a') || input.Equals('e') || input.Equals('i') || 
                input.Equals('o') || input.Equals('u'))
            {
                Console.WriteLine("Alphabet is Vowel");
            }
            else
            {
                Console.WriteLine("Alphabet is Consonant");
            }
        }
    }
}
