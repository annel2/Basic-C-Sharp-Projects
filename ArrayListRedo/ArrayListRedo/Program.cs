using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListRedo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numArray1 = new string[]{ "do", "re", "mi", "fa", "so" };
            Console.WriteLine("Select any number from zero to four.");
            Console.WriteLine(numArray1[Convert.ToInt32(Console.ReadLine())]);
            Console.ReadLine();

            int[] numArray2 = { 5, 10, 15, 20, 25, 30 };
            Console.WriteLine ("Select any number from zero to five");
            int number= Convert.ToInt32(Console.ReadLine());
            

            if ( number >5 || number<0) 
            {
                Console.WriteLine("Sorry, that number doesn't exist in this system.");
            }
            else
            {
                Console.WriteLine(numArray2[number]);

            }
            Console.ReadLine();


            List<string> stringList = new List<string>();
            stringList.Add("Jingle Bell Rock");
            stringList.Add("Carol of the Bells");
            stringList.Add("Let It Snow!");
            stringList.Add("Sleigh Ride");
            stringList.Add("Winter Wonderland");
            Console.WriteLine("Select any number from zero to four");
            int song= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringList[song]);
            Console.ReadLine();


        }
    }
}

               
