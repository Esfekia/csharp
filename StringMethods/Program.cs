using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim()); // 'Mosh Hamedani'
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper()); // 'MOSH HAMEDANI'

            //Substrings
            var index = fullName.IndexOf(' ');
            var firstName= fullName.Substring(0, index);
            var lastName= fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName); // First Name: Mosh
            Console.WriteLine("Last Name: " + lastName); // Last Name: Mosh

            //Split
            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]); // First Name: Mosh
            Console.WriteLine("Last Name: " + names[1]); // Last Name: Mosh

            //Replace
            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh")); //Moshfegh Hamedani

            //Working with Empty Strings, Nulls and WhiteSpaces
            if (String.IsNullOrEmpty(null))
                Console.WriteLine("Invalid"); // invalid
            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Invalid"); // no msg, since there is whitespace!
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("WhiteSpace Invalid"); // WhiteSpace Invalid
        }
    }
}
