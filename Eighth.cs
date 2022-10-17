// Program to check whether a given substring is present in the given string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Eighth
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("Enter the String :");
            str1 = Console.ReadLine();
            Console.WriteLine("\nEnter the Substring :");
            str2 = Console.ReadLine();
            bool lst;
            lst = str1.Contains(str2);
            if (lst)
            {
                Console.Write("The substring " + str2 + " is in the string " + str1);
            }
            else
            { 
            Console.Write("The substring " + str2 + " is not in the string " + str1);
            }
            Console.ReadLine();
        }
    }
 }

