using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really long text.";
            const int maxLength = 30;
            if (sentence.Length < maxLength)
                Console.WriteLine(sentence);
            else
            {

            }
        }
    }
}
