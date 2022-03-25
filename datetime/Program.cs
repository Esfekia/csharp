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

            Console.WriteLine(now.ToLongDateString());// Friday, March 25, 2022
            Console.WriteLine(now.ToShortDateString());// 3/25/2022
            Console.WriteLine(now.ToLongTimeString());// 5:35:21 AM
            Console.WriteLine(now.ToShortTimeString());// 5:35 AM

            Console.WriteLine(now.ToString());// 3/25/2022 5:39:03 AM
            Console.WriteLine(now.ToString("yyyy-MM-dd"));// 2022-03-25
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));// 2022-03-25 05:46
            Console.WriteLine(now.ToString("yyyyMMddHHmmssff"));// 2022032505495720
        }
    }
}
