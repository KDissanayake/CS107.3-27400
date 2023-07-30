using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_void_hello_world
{
    internal class helloworld
    {
        private void sayhello() //we wont be able to call it as the void is private and not public therefore the program.cs file cannot call it.
        {

            Console.WriteLine("Hello world :)"); 
        }
    }
}
