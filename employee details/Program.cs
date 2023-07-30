using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee employee = new employee();

            // Take user inputs
            Console.Write("Enter employee ID: ");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employee name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter employee designation: ");
            string empDesign = Console.ReadLine();

            // Set values using setter methods
            employee.EmpID = empID;
            employee.EmpName = empName;
            employee.EmpDesign = empDesign;

            // Get values using getter methods
            int retrievedEmpID = employee.EmpID;
            string retrievedEmpName = employee.EmpName;
            string retrievedEmpDesign = employee.EmpDesign;

            // Print the message
            Console.WriteLine("Hello, " + retrievedEmpName + "! Your employee ID is " + retrievedEmpID + " and you are a " + retrievedEmpDesign + ".");



        }
    }
}
