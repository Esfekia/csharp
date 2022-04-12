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
            /* FILE CLASS
             * var path = @"c:\temp\yourfile.jpg";
            var text = @"c:\temp\text.txt";
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
            Console.WriteLine(File.ReadAllText(text));
            //File.ReadAllBytes would open a binary file and read all contents of the file into a byte array
            */
            var path = @"c:\temp\myfile.jpg";
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"c:\temp\yourfile.jpg", true);
            fileInfo.Delete();
            if (fileInfo.Exists)
                Console.WriteLine("It exists!");
            else
                Console.WriteLine("It does not exist anymore.");
        }
    }
}
