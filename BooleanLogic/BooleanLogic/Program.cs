using System;


namespace BooleanLogic75

{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            bool qualified = (age > 15 && DUI == false && speedingTickets <= 3);
            Console.WriteLine(qualified);

            Console.ReadLine();
                

        }
   }
}
