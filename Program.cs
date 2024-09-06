using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            do
            { 
                //Prints out title of Program
                Console.WriteLine("Dice Rolling Program");
                //Divides space for visibility
                Console.WriteLine("");
                //
                RollDice();
                //Divides space for visibility
                Console.WriteLine("");
                //Prompts user if they wish to continue
                Console.WriteLine("Roll again? Y / N");
                //Converts user input to variable "userInput" as a string and lowers case to ensure loop escape is available
                userInput = Console.ReadLine().ToLower();
            } while (userInput != "n"); //Escape condition as long as "n" is not typed
        }
        public static void RollDice()
        {
            //Creates random class by defining it
            Random random = new Random();
            //Does two rolls with it being randomized with the parameters of 1-6 (7 declares highest but isn't possible to attain)
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            //Prints out rolls to user
            Console.WriteLine($"You rolled a {roll1} and {roll2}");
        }
    }
}
