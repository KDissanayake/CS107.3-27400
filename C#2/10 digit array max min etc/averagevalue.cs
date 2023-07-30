using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_digit_array_max_min_etc
{
    internal class averagevalue
    {

        // Calculate the average value of the array
        static double CalculateAverage(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }
    }
}
