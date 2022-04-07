using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// First Rule: You should always separate the code that works with
// the console from the code that implements some logic.
namespace ProceduralProgramming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Main method now only gets input from user and displays it.
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            //ReverseName method now only responsible for reversing the name.
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            return reversed;
        }
    }
}
