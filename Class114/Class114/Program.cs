using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class114
{
    class Program
    {
        static void Main(string[] args)
        {
            Math Peony = new Math();
            //int result = Math.SubtractThree(x: 8);
            Console.WriteLine(Math.SubtractThree(x: 8));
            Console.ReadLine();

            Math Dahlia = new Math();
            Console.WriteLine(Math.SubtractThree(x: 8.5m));
            Console.ReadLine();

            Math Tulip = new Math();
            Console.WriteLine(Math.SubtractThree(x: "5"));
            Console.ReadLine();


        }
    }
}
