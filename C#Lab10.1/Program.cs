using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Calculation calObj = new Calculation();

            calObj.setValues(num1, num2);

            Console.WriteLine("Sum : " + calObj.getadd());
            Console.WriteLine("Sub : " + calObj.getsub());
            Console.WriteLine("Multi : " + calObj.getmulti());
            Console.WriteLine("Div : " + calObj.getdiv());
        }
    }
}
