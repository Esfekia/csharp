using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5- Write a program and ask the user to enter an English word. 
 * Count the number of vowels (a, e, o, u, i) in the word. 
 * So, if the user enters "inadequate", the program should display 6 on the console.*/
namespace Chapter8Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an English word: ");
            var input = Console.ReadLine();
            var counter = 0;
            foreach (var letter in input)
                //Console.WriteLine(letter);
        }
    }
}
