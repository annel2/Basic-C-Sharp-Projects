using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhileLoop94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            //Do a boolean comparison using a while statement.
            bool magicNumber = number == 25;
            while (!magicNumber)
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine("You guessed 4.Try Again.");
                        Console.WriteLine("Choose a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 32:
                        Console.WriteLine("You guessed 32.Try Again.");
                        Console.WriteLine("Choose a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 25:
                        Console.WriteLine("You guessed 25. That is correct!");
                        magicNumber = true;
                        break;

                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Choose a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            //Do a boolean comparison using a do while statement.
            do
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine("You guessed 4.Try Again.");
                        Console.WriteLine("Choose a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 32:
                        Console.WriteLine("You guessed 32.Try Again.");
                        Console.WriteLine("Choose a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 25:
                        Console.WriteLine("You guessed 25. That is correct!");
                        magicNumber = true;
                        break;

                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Choose a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!magicNumber);
            Console.ReadLine();
        }
        
    }
}
