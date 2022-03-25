using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//DateTime System
namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015,1,1);
            //Could have gotten details all the way to seconds, miliseconds.
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Second: " + now.Second);
            //This will give a different output depending on RL datetime!
        }
    }
}
