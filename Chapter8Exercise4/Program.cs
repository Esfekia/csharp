using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*4- Write a program and ask the user to enter a few words separated by a space. 
 * Use the words to create a variable name with PascalCase. 
 * For example, if the user types: "number of students", display "NumberOfStudents". 
 * Make sure that the program is not dependent on the input. 
 * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".*/
namespace Chapter8Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a few words, seperated by a space. ");
            var input = Console.ReadLine();
            var names = input.Split(' ');
            var pascalNames = new StringBuilder();
            foreach (var word in names)
            {
                if (word.Length == 0)
                    Console.WriteLine("Empty string!");
                else if (word.Length == 1)
                    pascalNames.Append(char.ToUpper(word[0]));
                else                    
                    pascalNames.Append(char.ToUpper(word[0]) + word.ToLower().Substring(1));
            }
            Console.WriteLine(pascalNames);
        }
    }
}
