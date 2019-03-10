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
                
                if (today == DaysOfTheWeek.Monday
                    || today == DaysOfTheWeek.Tuesday || today == DaysOfTheWeek.Wednesday || today == DaysOfTheWeek.Thursday || today == DaysOfTheWeek.Friday || today == DaysOfTheWeek.Saturday || today == DaysOfTheWeek.Sunday)
                {
                    if (Response == "0" || Response == "1" || Response == "2" || Response == "3" || Response == "4" || Response == "5" || Response == "6")
                    {

                        throw new Exception();
                    }
                    Console.WriteLine(today);
                    Console.ReadLine();
                }
                else
                {
                    throw new ArgumentException("Please write a day of the week.");
                }

            }

            //4. Wrap the above statement in a try/catch block and have it print 
            //"Please enter an actual day of the week." to the console if an error occurs.
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();

            }
            
            finally
            {
                Console.ReadLine();
            }
        }
    }

}
