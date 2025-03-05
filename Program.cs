/* date             developer              changes
 * 3/4/2025        Celina                 Created the project
 * 3/4/2025        Celina                 Asked and read for user input
 * 3/4/2025        Celina                 Added 999 to the user input, printed the result
 * 
 * 
 * 
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Second line of text here.");


            // Ask user for a number and read it
            Console.WriteLine("Input a number: ");
            int UserInput = int.Parse(Console.ReadLine());

            // Making another change to Celina_Branch_1
            // Adding 999 to the user input
            int result = UserInput + 999;

            // Printing the result
            Console.WriteLine("The result is: " + result);



            // New branch will hold these changes.
            Console.WriteLine("Please rate how accurate this calculation is from 1 to 10: ");
            int rating = int.Parse(Console.ReadLine());

        }
    }
}
