//Program to count even and odd elements in an array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class First
    {
        static void Main(string[] args)
        {
            int i;
            int oddcount = 0,evencount=0;
            int[] array ;
            Console.Write("Enter the number of elements in the array :\n");
            int n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            Console.Write("Enter the elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in the array : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            for ( i = 0; i < n; i++)
            {
                
                if (array[i] % 2 == 0)
                {
                    evencount = evencount + 1;
                }
                else
                {
                    oddcount = oddcount + 1;
                }
            }
            Console.WriteLine("\nNumber of Even elements:{0}", evencount);
            Console.WriteLine("Number of Odd elements:{0}", oddcount);
            Console.ReadLine();

        }
    }
}
