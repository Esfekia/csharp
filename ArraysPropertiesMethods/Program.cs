using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPropertiesMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers = new int[] { 3, 7,, 9, 2, 14, 6 };
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);
        }
    }
}
