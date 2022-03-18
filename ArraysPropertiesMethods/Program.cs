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

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: "+ index);

            // Clear() <= int becomes 0, bool becomes false, string becomes null.
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
