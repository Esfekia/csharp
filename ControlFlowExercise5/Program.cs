using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 5- Write a program and ask the user to enter a series of numbers separated by comma. 
 * Find the maximum of the numbers and display it on the console. 
 * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
 */

namespace ControlFlowExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            Console.Write("Please enter the numbers, separated by a comma.");
            var input = Console.ReadLine();
            for (var i = 0; i < input.Length; i++)
            {
                Console.WriteLine(i);
                if (Char.IsDigit(input[i]))
                {
                    if (input[i] > maximum)
                    {
                        maximum = Convert.ToByte(input[i]);
                    }
                        
                }
                

            }
            Console.WriteLine("Maximum is: " + maximum);

        }
    }
}

/*
 * Console.Write("Enter a series of numbers, seperated by commas: ");
           
			var userInput = Console.ReadLine();

            var numbers = userInput.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

	}
}*/