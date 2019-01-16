using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum134
{
    class Program
    {
        //1. Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {

            try
            {
                //2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Please enter in the current day of the week.");
                string Response = Console.ReadLine();


                //3. Assign the value to a variable of that enum data type you just created.
                //converts string to enum
                DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Response);
                Console.WriteLine(today);
                Console.ReadLine();

            }

            bool isTrue = Response is int;
            
            bool isFalse = Response is string;
            
            
            
            

             //4. Wrap the above statement in a try/catch block and have it print 
             //"Please enter an actual day of the week." to the console if an error occurs.
            
            
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();

            }
            finally
            {
                Console.ReadLine();
            }
        } // public static bool operator == (Employee employee1, Employee employee2)
//        {
//            if (employee1.employee1ID == employee2.employee1ID)

//                return true;

//            else
//                return false;
//        }
//}

}
