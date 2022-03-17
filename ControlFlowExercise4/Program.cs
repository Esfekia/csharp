using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 4- Write a program that picks a random number between 1 and 10. 
 * Give the user 4 chances to guess the number. 
 * If the user guesses the number, display “You won"; otherwise, display “You lost". 
 * (To make sure the program is behaving correctly, 
 * you can display the secret number on the console first.)
 */
namespace ControlFlowExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var guess = random.Next(1, 10);
            var counter = 1;
            Console.WriteLine(guess);
            while (counter < 5)
            {               
                Console.Write("Guess Number: " + counter + " - Please enter a number between 1-10:");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == guess)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                counter++;
            }
        }
    }
}
