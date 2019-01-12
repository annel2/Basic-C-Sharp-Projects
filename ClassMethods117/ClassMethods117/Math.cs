using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods117
{
    class Math
    {
        public void Division(int x)
        {
            int quotient = x / 2;
            Console.WriteLine(quotient);

        }
        //Create a method with output parameters.
        public static void Sum(out int x)
        {
            x = 5 + 1;

        }
        //Overload a method.
        public static void Sum(int y, out int x)
        {
            x = 5 + 1;

        }
    }
}
