using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime156
{
    class Program
    {
        static void Main()
        {
            //Prints the current date and time to the console.
            DateTime current = DateTime.Now;
            Console.WriteLine(current);
            Console.ReadLine();

            //Asks the user for a number.
            Console.WriteLine("Please enter a number.");
            Double X = Convert.ToDouble(Console.ReadLine());
           
            
            // Prints to the console the exact time it will be in X hours, 
            //X being the number the user entered in step 2.
            Console.WriteLine(current.AddHours(X));
            Console.ReadLine();
            
        }
             
        
    }
   

}

