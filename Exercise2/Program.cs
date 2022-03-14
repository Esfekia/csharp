using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2- Write a program which takes two numbers from the console and displays the maximum of the two.
 */
namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input1 = Console.ReadLine();
            var number1 = Convert.ToInt32(input1);
            Console.Write("Enter another number: ");
            var input2 = Console.ReadLine();
            var number2 = Convert.ToInt32(input2);
            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is: "+ max);
        }
    }
}
