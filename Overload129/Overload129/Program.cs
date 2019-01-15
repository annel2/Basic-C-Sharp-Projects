using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload129
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.employee1ID = 1;

            Employee employee2 = new Employee();
            employee2.employee1ID = 1;
            
            Console.WriteLine("Employee1 is equal to Employee 2:" + (employee1 == employee2).ToString());
            Console.ReadLine();
            
        }   

    }


}









