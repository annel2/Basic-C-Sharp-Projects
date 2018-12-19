using System;


namespace IncomeComparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly rate?");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly rate?");
            int payrate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Weekly salary of Person 1:");
            int product = hourlyRate * hoursWorked;
            Console.WriteLine(product);

            Console.WriteLine("Weekly salary of Person 2:");
            int total = payrate * hoursNumber;
            Console.WriteLine(total);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueorFalse = product > total;
            Console.WriteLine(trueorFalse.ToString());

            Console.ReadLine();




        }
    }
}
