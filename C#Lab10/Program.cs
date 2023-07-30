using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Employee Id");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Name");
            string empDesignation = Console.ReadLine();

            Employee empObj = new Employee();

            empObj.setempID(empID);
            empObj.setempName(empName);
            empObj.setempDesignation(empDesignation);

            Console.WriteLine($"Hello" +empObj.getempName() + "Your Employee ID is"+empObj.getempID()+" and you are a " +empObj.getempDesignation());

        }
    }
}
