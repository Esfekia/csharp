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

            //TIME SPAN  - Represents a length of time.
            var timeSpan = new TimeSpan(1, 2, 3);// One hour, two minutes, three seconds.
            var timeSpan1 = new TimeSpan(1, 0, 0);// One hour.
            var timeSpan2 = TimeSpan.FromHours(1);// One hour too, but more readable!

            //Using datetime subtraction to get timespan:

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);// Duration: 00:02:00

            // Properties of TimeSpan
            Console.WriteLine("Minutes: " + timeSpan.Minutes);// Minutes: 2
            Console.WriteLine("Total Minutes: " +timeSpan.TotalMinutes);// Total Minutes: 62.05

            //Add - Subtract 
            Console.WriteLine("Add Example: " +timeSpan.Add(TimeSpan.FromMinutes(8)));
            // Add Example: 01:10:03
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(5)));
            // Subtract Example: 00:57:03
        }
    }
}
