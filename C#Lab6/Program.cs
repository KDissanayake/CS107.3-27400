using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab6
{
    internal class Program
    {
        //create a c# console application to find the area and the circumferance of a circle. user should insert the raduis value to the program.program should contain a separate class call "FindValues". Inside the separate class add two methods call findArea and findCircumference. Both these methods are methods which takes parameters. As the parameter you should pass the radius value. By using above two methods find the area and circumference of the circle and return the answer from both methods. Create a class object in main class and call both methods and display the answers.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues circle = new FindValues();
            double area = circle.FindArea(radius);
            double cir = circle.FindCir(radius);

            Console.WriteLine($"Area : {area} and the Circumferance : {cir} of the circle");
            Console.ReadLine();
        }
    }
}
