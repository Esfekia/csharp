using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\yourfile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp\yourfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("It exists!");
            }
            else
            {
                Console.WriteLine("It got deleted!");
            }
        }
    }
}
