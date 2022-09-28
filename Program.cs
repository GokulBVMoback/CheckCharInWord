using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCharInWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.Write("Enter the word:");
            word = Console.ReadLine();
            if(word.Contains("G"))
            {
                Console.WriteLine("Given word "+word+ " contains G");
            }
            else 
            {
                Console.WriteLine("Given Word "+word+" not contains G");
            }
        }
    }
}
