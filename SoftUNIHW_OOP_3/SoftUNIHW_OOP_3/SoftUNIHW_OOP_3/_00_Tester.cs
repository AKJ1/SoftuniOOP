using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * START HERE! 
 * I realize the naming of the 
 * files is not conventional.
 * however i've broken the convention
 * so that it is easier for you to
 * check the source code - They're 
 * numerically sorted for your convenience.
 * Start this file to go through all the Homeworks.
 */
namespace SoftUNIHW_OOP_3
{
    class _00_Tester
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;;
            Console.WriteLine("You are about to go through the tests for this homework. Press the any key to go to the next problem.");
            Console.WriteLine("You are about to check out Problem 1: Square Root");
            Console.ForegroundColor = ConsoleColor.Gray;
            SquareRoot.GetSQRT();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nice, huh? Press the any key AGAIN to continue.");
            Console.ReadKey();
            Console.WriteLine("You are about to check out Problem 2: Enter Numbers");
            Console.ForegroundColor = ConsoleColor.Gray;
            EnterNumbers.ReadNumber(0, 10);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Great, right?");
            Console.WriteLine("Well, that was everything from this assignment, press the any key to exit.");
            Console.ReadKey();

        }
    }
}
