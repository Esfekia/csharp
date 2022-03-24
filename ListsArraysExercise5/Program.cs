using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5- Write a program and ask the user to supply a list of comma separated numbers
//(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers,
//display "Invalid List" and ask the user to re-try;
//otherwise, display the 3 smallest numbers in the list.
namespace ListsArraysExercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements;
            while (true)
            {
                Console.Write("Please enter 5 numbers, separated by comma. ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid input. Please enter 5 numbers, separated by comma. ");
            }
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallest = new List<int>();
            while (smallest.Count < 3)
            {
                //Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallest.Add(min);
                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are:");
            foreach (var number in smallest)
                Console.WriteLine(number);

        }
    }
}
