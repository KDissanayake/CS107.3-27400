using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab5Funtions
{
    internal class Program
    {
        /*//no return type,no parameters
        static void Main(string[] args)
        {
            
            myName();
            Console.ReadLine(); 
        }

        public static void myName()
        {
            Console.WriteLine("Kithma");
        }*/


        /*  // with parameter,no return type
          static void Main(string[] args)
          {
              Console.Write("Enter your name :");
              string name = Console.ReadLine();
              myName(name);
              Console.ReadLine();
          }

          public static void myName(String para)
          { 
            Console.WriteLine(para);
          }*/

        /*//no parameter, with return type

        static void Main(string[] args)
        {
            String a = takeName();
            Console.WriteLine(a);
            Console.ReadLine();
        }

        public static String takeName()
        {
            Console.Write("Enter name:");
            string name = Console.ReadLine();

            return name;

        }*/

/*
        //get 2 user inputs(inside main)
        //then calculate summation and return type in the function call 'get sum'
        //print sum inside the main
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value to the number 1");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value to the number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Answer is :" + getSum(num1, num2));
            Console.ReadLine();

        }

        public static int getSum(int num1,int num2)
        {
            int sum = num1 + num2;
            return sum;
        }*/
    }
}
