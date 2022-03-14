using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            /* bool isGoldCustomer = false;
              float price;
                if (isGoldCustomer)
                    price = 19.95f;
                else
                    price = 29.95f;

                 float price = (isGoldCustomer) ? 19.95f : 29.95f;
                 Console.WriteLine(price);
            */
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn and a beautiful season.");
                    break;

                case Season.Summer:
                    Console.WriteLine("It's Summer and perfect to go to beach.");
                    break;
                default:
                    Console.WriteLine("I do not understand the season.");
                    break;
            }

        }
    }
}
