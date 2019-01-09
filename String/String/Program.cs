using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Anne";
            string action = "eats";
            string target = "cake!";
            

            Console.WriteLine(name+ " "+ action+ " "+ target);

            string statement = "The best sauce is Hunger!";
            statement = statement.ToUpper();
            Console.WriteLine(statement);

            StringBuilder sb = new StringBuilder();
            sb.Append("Christmas is next week!");
            sb.Append(" I am looking forward to spending time with my family.");
            sb.Append(" I am hoping for a better year in 2019!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
