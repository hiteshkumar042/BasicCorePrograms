using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelOrConsonant
    {
        public void VowelOrConsonantFn()
        {
            Console.WriteLine("Enter a character: ");
            Char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Entered character {0} is a vowel.", ch);

            }
            else
            {
                Console.WriteLine("Entered Character {0} is a consonant.", ch);
            }
        }
    }
}
