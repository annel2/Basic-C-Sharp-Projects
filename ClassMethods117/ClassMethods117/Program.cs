using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods117
{
    class Program
    {
        //Declare a class to be static.
        static void Main(string[] args)
        {
            Math Puppy = new Math();
            Console.WriteLine("Please input a number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Puppy.Division(x);

            Math.Sum(out x);

            Console.ReadLine();
        }
    }
}
