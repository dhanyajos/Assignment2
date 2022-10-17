// Program to sort an array(Accept values from user)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Fourth
    {
        static void Main(string[] args)
        {
            int i,j,temp=0;
            int[] array = new int[8];
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
                for (j = i + 1; j < n-1; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.Write("\nElements in array after Sorting: ");
            for ( i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.ReadLine();
        }
    }
}
