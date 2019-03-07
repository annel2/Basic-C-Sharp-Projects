using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionHandling165
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //1.Ask the user for his age.
                Console.WriteLine("Please enter your age.");
                //2.Display the year user born.
                // 2019 +(AddYear) (-32 age)-> 2019+-32-> 1987-> convert the whole thing to year.
                int Age = DateTime.Now.AddYears(-Convert.ToInt32(Console.ReadLine())).Year;
                //3. Exceptions must be handled using "try .. catch".
                if (Age >= 2019)
                {
                    throw new IllegalArgumentException();
                }
                Console.WriteLine("You were born in " + Age + ".");
                Console.ReadLine();

            }
            //4.Display appropriate error messages if user enters zero or negative numbers.
            catch (IllegalArgumentException)
            {
                Console.WriteLine("Enter only positive number.");
                Console.ReadLine();
            }
            //5.Display a general message if exception caused by anything else.
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return;
            }
        }
    }
}
