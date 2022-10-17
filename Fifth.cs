// Program to add diagonal elements of two-dimensional array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Fifth
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] arr = new int[3, 3]
            {
                {3,4,8},
                {2,4,5},
                {2,6,8}
            };
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if(i == j)
                    {
                        sum = sum + arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of Diagonal elements of an Array:{0}", sum);

            Console.ReadLine();
        }
    }
}
