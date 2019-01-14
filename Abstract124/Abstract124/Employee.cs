using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract124
{
    class Employee : Person, IQuittable
    {
        //Have your Employee class from the previous drill inherit that interface 
        //and implement the Quit() method in any way you choose.
        public void Quit()
        {

        }

        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        
       
        
    }
}
