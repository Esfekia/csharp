﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Directory.CreateDirectory(@"c:\temp\folder1");

            //var files = Directory.GetFiles(@"c:\temp\two", "*.*",SearchOption.AllDirectories);
            var files = Directory.GetFiles(@"c:\temp\two", "*.jpg", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);
            */
            var directories = Directory.GetDirectories(@"c:\temp\folder1", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);
        }
    }
}
