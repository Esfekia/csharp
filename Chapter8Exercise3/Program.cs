using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
 * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
 * otherwise, display "Invalid Time". 
 * If the user doesn't provide any values, consider it as invalid time.*/
namespace Chapter8Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var invalidTime = false;
            while (true)
            {
                Console.WriteLine("Please enter a time in the 24-hour time format (e.g. 19:00). ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    invalidTime = true;
                    Console.WriteLine("Invalid Time");
                    break;
                }
                if (DateTime.TryParse(input, out DateTime result) == false)
                {
                        invalidTime = true;
                        Console.WriteLine("Invalid Time");
                        break;
                }
                if (!invalidTime)
                    Console.WriteLine("Ok");

            }
                      
                
        }
    }
}
