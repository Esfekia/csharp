using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2- Write a program and continuously ask the user to enter a number or "ok" to exit.
//Calculate the sum of all the previously entered numbers and display it on the console.
namespace ControlFlowExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            while (true)
            {
                Console.Write("Please enter a number, or type 'ok' to exit.");
                var input = Console.ReadLine();
                if (input == "ok")
                    break;
                else
                    counter = counter + int.Parse(input);                
            }
            Console.WriteLine("Your total is: " + counter);
        }
    }
}
