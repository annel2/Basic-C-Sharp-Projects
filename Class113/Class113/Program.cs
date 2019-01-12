using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class113
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class.
            Math zebra = new Math();

            //Call the method in the class, passing in two numbers.
            Math.MultiplybyFive(5, 10);

            //Call the method in the class, specifying the parameters by name.
            Math.MultiplybyFive(x: 5, y: 10);
            Console.ReadLine();
        }
    }
}
