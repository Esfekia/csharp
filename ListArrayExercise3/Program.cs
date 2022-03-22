using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3- Write a program and ask the user to enter 5 numbers.
//If a number has been previously entered,
//display an error message and ask the user to re-try.
//Once the user successfully enters 5 unique numbers,
//sort them and display the result on the console.
namespace ListArrayExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var counter = 0;
            var numbers = new int[5];
            ;
            while (counter < 5)
            {
                Console.Write("Please enter 5 unique numbers, one at a time: ");
                var entry = int.Parse(Console.ReadLine());
                bool containsNumber = false;
                foreach (var number in numbers)
                {
                    if (number == entry)
                    {
                        containsNumber = true;
                        break;
                    }                                         
                }
                if (containsNumber == true)
                {
                    Console.WriteLine("Duplicate number entered. Please try again.");
                }
                else
                {
                    numbers[counter] = entry;
                    counter++;
                }
            }
            Array.Sort(numbers);
            Console.WriteLine("Here is the sorted list of your numbers:");  
            
            foreach (var n in numbers)
                Console.WriteLine(n);
                
               

  
                
                





        }
    }
}
