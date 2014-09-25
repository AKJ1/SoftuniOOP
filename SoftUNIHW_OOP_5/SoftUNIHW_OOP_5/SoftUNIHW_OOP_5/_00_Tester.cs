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
            nextProblem("You are about to check out Problem 1: InterestCalculator.");
            InterestCalculator.Test();
            nextProblem("\n\n\nYou are about to check the Second Problem : Async Timer");
            AsyncTimer.Tester();
            //nextProblem("Looks like this was everything.");
            nextProblem("\n\nNext, you're going to see Problem 3: Student Class");
            Student.Tester();
            exit();
        }

        static void startProblems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are about to go through the tests for this homework.\n\n\n");
        }
        static void nextProblem(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine(message);
            Console.WriteLine("Press the Any key to Proceed.\n\n");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void exit()
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("\n\nI Guess those were all the problems.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press the any key to exit");
            Console.ReadKey();
        }
    }
}
