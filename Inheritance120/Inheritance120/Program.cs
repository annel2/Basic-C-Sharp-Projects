using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee();
            Employee1.FirstName = "Sample";
            Employee1.LastName = "Student";
            Employee1.SayName();
            
            Console.ReadLine();
        }
    }
}
