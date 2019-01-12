using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class115
{
    class Program
    {
        static void Main(string[] args)
        {
            Math Kitty = new Math();
            Console.WriteLine("Please enter the first number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number as an option.");
            string z = Console.ReadLine();
            Console.WriteLine("The product of your input(s) equals:");
            if (z != "")
            {
                int y = Convert.ToInt32(z);
                Console.WriteLine(Math.Multiplication(x,y));
            }
            else
            {
                Console.WriteLine(Math.Multiplication(x));

            }

            Console.ReadLine();


        }
    }
}
