using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct137
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create an object of data type Number and assign an amount to it.
            Number number1 = new Number();
            number1.Amount = 5000m;

            //3. Print this amount to the console.
            Console.WriteLine(number1.Amount);
            Console.ReadLine();

        }
    }



}
