using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpressions140
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees. 
            //Each employee should have a first and last name, as well as an Id. 
            //At least two employees should have the first name "Joe".
            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(new Employee { firstName = "Joe", lastName = "Jonas", ID = 1 });
            allEmployees.Add(new Employee { firstName = "Jennifer", lastName = "Aniston", ID = 2 });
            allEmployees.Add(new Employee { firstName = "Anna", lastName = "Faris", ID = 3 });
            allEmployees.Add(new Employee { firstName = "Jimmy", lastName = "Fallon", ID = 4 });
            allEmployees.Add(new Employee { firstName = "Chris", lastName = "Pratt", ID = 5 });
            allEmployees.Add(new Employee { firstName = "Tina", lastName = "Fey", ID = 6 });
            allEmployees.Add(new Employee { firstName = "Amy", lastName = "Poehler", ID = 7 });
            allEmployees.Add(new Employee { firstName = "Ben", lastName = "Affleck", ID = 8 });
            allEmployees.Add(new Employee { firstName = "Brad", lastName = "Pitt", ID = 9 });
            allEmployees.Add(new Employee { firstName = "Joe", lastName = "Biden", ID = 10 });

            foreach (Employee emp in allEmployees)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName + " " + emp.ID);

            }

            //Using a foreach loop, create a new list of all employees with the first name "Joe".
            foreach (Employee emp in allEmployees)
            {
                if (emp.firstName == "Joe")
                {
                    Console.WriteLine(emp.firstName + " " + emp.lastName + " " + emp.ID);
                }

            }

            // Do the same thing again, but this time with a lambda expression.
            List<Employee>EmployeesNamedJoe = allEmployees.Where(emp => emp.firstName == "Joe").ToList();
            foreach(Employee emp in EmployeesNamedJoe)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName+ " " + emp.ID);
               
            }

            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee>GreaterThanFive = allEmployees.Where(emp => emp.ID > 5).ToList();
            foreach(Employee emp in GreaterThanFive)
            {
                Console.WriteLine(emp.firstName + " " + emp.lastName + " " + emp.ID);
            }
            Console.ReadLine();
                
        }


    }

}
    

