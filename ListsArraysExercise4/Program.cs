using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4- Write a program and ask the user to continuously enter a number or type "Quit" to exit.
//The list of numbers may include duplicates.
//Display the unique numbers that the user has entered.

namespace ListsArraysExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var enteredQuit = false;
            var numbers = new List<int>();
            while (!enteredQuit)
            {
                Console.Write("Please enter a number. Type 'quit' to exit. ");
                var entry = Console.ReadLine();
                if (entry.ToLower() == "quit")
                    break;
                if (!numbers.Contains(int.Parse(entry)))
                {
                    numbers.Add(int.Parse(entry));
                }

            }
            Console.WriteLine("Here are the unique numbers you entered:");
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
