using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Display even numbers between 1-10
            /*            for (var i = 1; i <= 10; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
            //What if you want to display the numbers from reverse order?
                        for (var i = 10; i > 0; i--)
                        {
                            if ((i % 2) == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
            */
            var name = "John Smith";
            /*
            for (var i =0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            */
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
