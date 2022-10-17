// Program to store all negative elements in an array to another array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Third
    {
        static void Main(string[] args)
        {
            int i;
            int[] array1 ;
            int[] array2 ;
            Console.Write("Enter the number of elements in the array :\n");
            int n = Convert.ToInt32(Console.ReadLine());
            array1 = new int[n];
            array2 = new int[n];
            Console.Write("Enter the elements in the array :\n");
            for (i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in the array : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array1[i]);
            }

            Console.WriteLine("\nNegative elements in the new array:");
            for (i=0 ; i<array1.Length;i++)
            {
                if (array1[i] < 0)
                    {
                        array2[i] = array1[i];
                        Console.WriteLine(array2[i]);
                }
             }
         Console.ReadLine();

        }
    }
}
