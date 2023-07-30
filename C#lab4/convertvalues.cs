using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_lab4
{
    internal class convertvalues
    {
        public void KilometerToMeter()
        {
            Console.Write("Enter the values in kilometers");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            double meters = kilometers * 1000;

            Console.WriteLine($"{kilometers} equal to {meters} meters");
            

        }
    }
}
