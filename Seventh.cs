// Find total number of vowels in a string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Seventh
    {
        static void Main(string[] args)
        {
           
            int i, count=0;
            Console.WriteLine("Enter the String :");
            string str = Console.ReadLine();

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    count=count+1;
                }
                
            }
            Console.Write("\nVowels in the string: {0}:", count);
            Console.ReadLine();
        }
    }
}
