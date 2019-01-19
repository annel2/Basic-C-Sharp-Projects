using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling154
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask a user for a number.
            Console.WriteLine("Please enter a number.");
            string text = Convert.ToString(Console.ReadLine());


            ////2. Log that number to a text file.
            File.WriteAllText("C:\\Sample\\log.txt", text);

            ////3. Print the text file back to the user.
            text = File.ReadAllText("C:\\Sample\\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }        

    }

}
