using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics131
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type "string" as its generic parameter. 
            Employee<string> employee1 = new Employee<string>();

            //Assign a list of strings as the property value of Things.
            employee1.Things = new List<string>();
            employee1.Things.Add("IDbadge");
            employee1.Things.Add("computer");
            employee1.Things.Add("desk");
            employee1.Things.Add("phone");

            //Instantiate an Employee object with type "int" as its generic parameter.
            Employee<int> employee2= new Employee<int>();

            //Assign a list of integers as the property value of Things.
            employee2.Things = new List<int>();
            employee2.Things.Add(1);
            employee2.Things.Add(2);
            employee2.Things.Add(5);
            employee2.Things.Add(7);

            //Create a loop that prints all of the Things to the Console.
            foreach (var thing in employee1.Things)
            {
                Console.WriteLine(thing);
                
            }
            foreach(var thing in employee2.Things)
            {
                Console.WriteLine(thing);

            }
            Console.ReadLine();

        }
    }

    
}
