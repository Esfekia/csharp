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

            var text = "Hi John\nLook into the following paths \n c:\\folder1\\folder2\nc:\\folder3\\folde4";
            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folde4";
            Console.WriteLine(text);   
            Console.WriteLine(text2);
            
        }
    }
}
