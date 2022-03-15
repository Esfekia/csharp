using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program and ask the user to enter the width and height of an image. 
 * Then tell if the image is landscape or portrait.
 * */
namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the width:");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height:");
            var height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("This image is landscape.");
            }
            else
            {
                Console.WriteLine("This image is portrait.");
            }

        }
    }
}
