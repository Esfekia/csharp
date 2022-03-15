using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Speed Camera
 * */
namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the current speed: ");
            var currentSpeed = Convert.ToInt32(Console.ReadLine());

            var demerit = Convert.ToInt32((currentSpeed - speedLimit) / 5);
            if (currentSpeed <= speedLimit)
            {
                Console.WriteLine("Ok.");
            }    
            else if (demerit <= 12)
            {
                Console.WriteLine("You have incurred " + demerit + " points.");
            }
            else if (demerit > 12)
            {
                Console.WriteLine("License suspended.");
            }


        }
    }
}
