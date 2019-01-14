using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract124
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside the Main() method, instantiate an Employee object 
            //with firstName "Sample" and lastName "Student". 
            Employee Employee1 = new Employee();
            Employee1.firstName = "Sample";
            Employee1.lastName = "Student";

            //Call the SayName() method on the object.
            Employee1.SayName();
            Console.ReadLine();

            //Use polymorphism to create an object of type IQuittable 
            //and call the Quit() method on it. 
            IQuittable Employee = new Employee();
            Employee.Quit();

        }
    }
}
   