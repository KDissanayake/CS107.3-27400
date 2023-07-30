using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab8
{
    internal class Program
    {
        /* static void Main(string[] args)
         {
             int[] num = new int[10];
             int sum = 0;

             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine("Enter Value : ");
                 num[10] = int.Parse(Console.ReadLine());

             }
             for (int i = 0; i < 10; i++)
             {
                 sum = sum + num[i];

             }
             Console.ReadKey();
         }*/

        /* static void Main(string[] args)
         {
             int[] num = { 4, 9, 7, 5, 8, 33, 9, 99, 6 };

             int smallest = num[0];
             int biggest = num[0];

             for (int i = 0; i < num.Length; i++)
             {
                 if (smallest > num[i])
                 {
                     smallest = num[i];
                 }
                 if (biggest > num[i])
                 {
                     biggest = num[i];
                 }
                 Console.WriteLine("Smallest : " + smallest + "Biggest : " + biggest);
             }
             Console.ReadKey();
         }*/

        /*static void Main(string[] args)
        {
            int[] num = { 4, 9, 7, 5, 8, 33, 9, 99, 6 };

            for(int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[j] > num[j+1])
                    {
                        int temp = num[j];
                        num[j] = num[j+1];
                        num[j+1] = temp;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]+" ");
            }
            Console.ReadKey();
        }*/

        static void Main(string[] args)
        {
            int[,] num = { { 10, 20 }, { 23, 43 } };

            int min = num[0, 0];
            int max = num[0, 0];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (num[i, j] < min)
                    {
                        min = num[i, j];
                    }

                    if (num[i, j] < max)
                    {
                        max = num[i, j];
                    }
                }
            }
            Console.WriteLine("Min : " + min);
            Console.WriteLine("Max : " + max);
            Console.ReadKey();
        }
    }
}
