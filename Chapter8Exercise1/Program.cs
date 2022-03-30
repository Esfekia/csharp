using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1- Write a program and ask the user to enter a few numbers separated by a hyphen.
//Work out if the numbers are consecutive.
//For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
//"Consecutive"; otherwise, display "Not Consecutive".
namespace Chapter8Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool consecCheckInc = true;
            bool consecCheckDec = true;
            Console.Write("Please enter a few numbers, seperated by a hyphen. ");
            var input = Console.ReadLine();
            var trimmed = input.Split('-');
            var numbers = new List<int>();
            
            foreach (var number in trimmed)
                numbers.Add(Convert.ToInt32(number));
                
            for (int i =0; i<(numbers.Count-1); i++)
                if (!(numbers[i] == numbers[i+1]-1))
                {
                    consecCheckInc = false;
                    break;
                }
            for (int i =numbers.Count-1; i>0; i--)
                if (!(numbers[i] == numbers[i-1]-1))
                {
                    consecCheckDec = false;
                    break;
                }
                                
            if (consecCheckInc | consecCheckDec)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");

        }
    }
}
