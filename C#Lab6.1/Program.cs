using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab6._1
{
    internal class Program
    {
        /*Create the below mentioned console application and display it to the user. If user need to do an Addition user need to insert 1 as the choice. For subtraction it should be 2 etc. Your program should contain a separate class call "Calculate Values" and inside the class you should add four methods which perform four arithmetic operations. All the methods should take two parameters which are user inserted numbers. And at the end of the method return the answer out of the method. In main class if user want to do an addition call only the addition method in separate class. If user want to do a subtraction call only the subtraction method in separate class. Etc. And display the final answer as shown in the figure 01.
        Enter 1 for Addition
        Enter 2 for Subtraction
        Enter 3 For Multiplication
        Enter 4 for Division
        Enter Your Choice : 3
        Enter Number 1: 25
        Enter Number 2: 2
        Your Answer is : 50*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 For Multiplication");
            Console.WriteLine("Enter 4 for Division");

            Console.WriteLine("Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            CalValues cal = new CalValues();
            double result = 0;

            switch(choice)
            {
                case 1:
                    result = cal.Addition(num1 ,num2);
                    break;
                case 2:
                    result = cal.Substraction(num1 ,num2);
                    break;
                case 3:
                    result = cal.Multipication(num1 ,num2);
                    break;
                case 4:
                    result = cal.Division(num1 , num2);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.WriteLine("Your answer is " + result);
            Console.ReadKey();

        }
    }
}
