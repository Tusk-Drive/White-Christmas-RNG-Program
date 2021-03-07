using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace White_Christmas_Program_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to the WhiteChristmas random number Generator!!!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You where given a number when you walked in if your number is called then step up and play the game!");
            Console.WriteLine("Press R to genrate a number, and press R again to get a new number");
            Console.WriteLine("press any other key to exit the program");
            Console.ResetColor();

            while (Console.ReadKey(true).Key == ConsoleKey.R)// This sets a condition to press r to get a new number
            {
                RandomNumber();
            }
          

        }

        static void RandomNumber()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 14);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The card that is picked is:" + dice);
            Console.ResetColor();

        }
    }
        
}
