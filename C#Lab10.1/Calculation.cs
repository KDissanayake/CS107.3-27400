using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab10._1
{
    internal class Calculation
    {
        private double number1;
        private double number2;

        public void setValues(double num1,double num2)
        {
            number1 = num1;
            number2 = num2;
        }

        public double getadd()
        {
            return number1 + number2;
        }
        public double getsub()
        {
            return number1 - number2;
        }
        public double getmulti()
        {
            return number1 + number2;
        }
        public double getdiv()
        {
            return number1 + number2;
        }
    }
}
