using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Mosh";
            var lastName = "Hamedani";

            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0}, {1}", firstName, lastName);
            
            var names = new string[3] { "John", "Jack", "Mary"};
            var formattedNames = string.join(",", names);
            Console.WriteLine(formattedNames);

            
        }
    }
}
