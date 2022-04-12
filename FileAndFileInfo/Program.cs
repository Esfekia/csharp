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
            File.Copy("c:\\temp\\myfile.jpg", "c:\\temp\\yourfile.jpg", true);
        }
    }
}
