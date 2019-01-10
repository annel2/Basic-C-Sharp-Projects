using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "rose", "tulip", "lily", "iris", "dahlia", "peony" };
            Console.WriteLine("Please input a text");
            string input = Console.ReadLine();
            for (int f = 0; f < names.Length; f++)
            {
                Console.WriteLine(names[f] + " " + input);
            }
            for (int f = 0; f < names.Length; f++)
            {
                Console.WriteLine(names[f]);

            }
            
            int number = 1;
            for (int i = 0; i < number; i--)
            {
                Console.WriteLine("Confusion");
            }
            for (int i = 0; i < number; i = 1)
            {
                Console.WriteLine("Confusion");
            }


            int total = 10;
            for (int i = 0; i < total; i++)
            {

            }
            for (int i = 0; i <= total; i++)
            {

            }

            List<string> places = new List<string>() { "beach", "mountain", "lake", "desert", "valley", "forest" };
            Console.WriteLine("Pick one of these places.");
            string answer = Console.ReadLine();
            for (int i = 0; i < places.Count; i++)
            {
                if (answer==places[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            
            }
            if (!places.Contains(answer)) 
            {
                Console.WriteLine("Your answer is not found.");
            }


            List<string> persons = new List<string>() { "Molly", "Simmon", "David", "Anna", "Peter", "Molly", "Kevin" };
            Console.WriteLine("Pick one of the above names. ");
            string name = Console.ReadLine();
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i]==name)
                {
                    Console.WriteLine(i);
                }
            }
            if(!persons.Contains(name))
            {
                Console.WriteLine("Your name is not found.");
            }

            List<string> colors = new List<string>() { "red", "blue", "green", "brown", "black", "blue", "yellow", "white", "orange","blue"};
            List<string> uniqueColors = new List<string>();

            foreach(string color in colors)
            {
                if(uniqueColors.Contains(color))
                {
                    Console.WriteLine("This color has already appeared in the list.");
                }
                else
                {
                    Console.WriteLine("This color has not yet appeared in the list.");
                    uniqueColors.Add(color);
                }
            }



            Console.ReadLine();




        } 
    }
}


