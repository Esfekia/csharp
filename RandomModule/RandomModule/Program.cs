﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomModule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            char[] buffer = new char[10];
            for (var i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            var password = new string(buffer);
            Console.WriteLine(password);
                //Console.Write((char)random.Next(97,122)); OR
                //Console.Write((char)('a' + random.Next(0,26)));
                //Console.WriteLine();
            
        }
    }
}
