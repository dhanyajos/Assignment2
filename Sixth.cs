
// Find total number of words in a string?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Sixth
    {
        static void Main(string[] args)
        {
            int n = 0, word = 1;
            string str;
            Console.WriteLine("Enter the String :");
            str = Console.ReadLine();
          
            while (n <= str.Length-1)
            {
                if (str[n] == ' ')
                {
                    word++;
                }
                n++;
            }
            Console.Write("Number of words in the string = {0}\n", word);
            Console.ReadLine();
        }
    }
}
