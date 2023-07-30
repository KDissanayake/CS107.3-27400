using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab6
{
    internal class FindValues
    {
        public double FindArea(double radius) 
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public double FindCir(double radius)
        {
            double cir = 2 * Math.PI * radius;
            return cir;
        }
    }
}
