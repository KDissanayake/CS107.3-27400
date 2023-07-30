using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int marks;

            Console.WriteLine("Enter the students name: ");
            name = Console.ReadLine(); 

            Console.WriteLine("Enter the students marks: ");
            marks =Convert.ToInt32(Console.ReadLine());

            while(marks <0 || marks >100)
            {
                Console.WriteLine("Invalid Marks");
                marks =Convert.ToInt32(Console.ReadLine());
            }

            string grade;
            if (marks >= 75 && marks <= 100)
            {
                grade = "A";
            }
            else if (marks >= 60 && marks <= 74)
            {
                grade = "B";
            }
            else if (marks >= 50 && marks <= 59)
            {
                grade = "C";
            }
            else if (marks >= 40 && marks <= 49)
            {
                grade = "D";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Student name " + name);
            Console.WriteLine("Student grade " + grade);
            Console.ReadLine();
        }
    }
}
