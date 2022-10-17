//Program to find sum of array elements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Second
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            int[] array;
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
            foreach (int lst in array)
            {
                sum = sum + lst;
            }
               
            Console.WriteLine("\nSum of Array:{0}", sum);
           
            Console.ReadLine();

        }
    }
}
