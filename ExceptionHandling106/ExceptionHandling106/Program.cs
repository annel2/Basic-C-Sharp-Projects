using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> powerballNumbers = new List<int>() { 4, 20, 49, 26, 7, 12 };
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < powerballNumbers.Count; ++i)
                {
                    int total = powerballNumbers[i] / numberOne;
                    Console.WriteLine(powerballNumbers [i] + " divide by " + numberOne + " equals " + total);
                    Console.ReadLine();
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Please use a whole number.");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }


    }

}
