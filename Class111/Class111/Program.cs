using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            int product = Math.MultiplybyTwo(numberOne);
            Console.WriteLine(numberOne + " multiply by two" + " equals " + product);
            Console.ReadLine();


            int quotient = Math.DividebyTwo(numberOne);
            Console.WriteLine(numberOne + " divide by two" + " equals " + quotient);
            Console.ReadLine();
           
            int sum = Math.AddTwo(numberOne);
            Console.WriteLine(numberOne + " add two" + " equals " + sum);
            Console.ReadLine();

        }
    }
}
