using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * If the user simply presses Enter, without supplying an input, exit immediately; 
 * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
 */
namespace Chapter8Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements= null;
            //var isDuplicate = false;
            while (true)
            {
                Console.WriteLine("Please enter a few numbers, separated by a hyphen. ");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Thank you, have a nice day!");
                    break;
                }
                    
                else if (input != null)
                {
                    elements = input.Split('-');
                }
                
            }
            var numbers = new List<int>();
            
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));
            
            if (numbers.Count != numbers.Distinct().Count())
                Console.WriteLine("Duplicate");
        }
    }
}
