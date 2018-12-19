using System;

namespace Math1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            int product = number * 50;
            Console.WriteLine(product);

            Console.WriteLine("Enter a number.");
            int digit = Convert.ToInt32(Console.ReadLine());
            int total = digit + 25;
            Console.WriteLine(total);

            Console.WriteLine("Enter a number.");
            decimal result = Convert.ToDecimal(Console.ReadLine());
            decimal quotient = result / 12.5m;
            Console.WriteLine(quotient);

            Console.WriteLine("Enter a number.");
            int input = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = input > 50;
            Console.WriteLine(trueOrFalse.ToString());

            Console.WriteLine("Enter a number.");
            int entry= Convert.ToInt32(Console.ReadLine());
            int remainder = entry % 7;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
