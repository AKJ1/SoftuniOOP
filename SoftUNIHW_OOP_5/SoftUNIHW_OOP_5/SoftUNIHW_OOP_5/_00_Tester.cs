using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_5
{
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
    class Tester
    {
        static void Main(string[] args)
        {
            startProblems();
            nextProblem("You are about to check out Problem 1: InterestCalculator.\nPress the Any key to Proceed.\n\n\n");
            InterestCalculator.Test();
            //nextProblem("Next we'll do Problem 2: FractionCalculator. \nPress the Any key to Proceed.");
            //nextProblem("Next up is Generic List. The big one of this Homework.\nPress the Any Key to Proceed");
            //nextProblem("Looks like this was everything.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press the any key to exit");
            Console.ReadKey();



        }

        static void startProblems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are about to go through the tests for this homework.\n\n\n");
        }
        static void nextProblem(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green; ;
            Console.WriteLine(message);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
