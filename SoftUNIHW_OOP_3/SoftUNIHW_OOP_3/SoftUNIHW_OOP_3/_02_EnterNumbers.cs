using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_3
{
    class EnterNumbers
    {
        public static void ReadNumber(int start, int end)
        {
            
            uint lastNumber = 1;
            uint[] numberArray = new uint[end-start];
            for (int i = start; i < end; i++)
            {
                try
                {
                    uint currentNumber = EnterNumber(lastNumber);
                    if (currentNumber <= lastNumber)
                    {
                        throw new InvalidDataException();
                    }
                    lastNumber = currentNumber;
                    numberArray[i] = lastNumber;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exception Caught! Number did not fit the Criteria or was not a number!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                
            }
            Console.WriteLine("\n\n\nThe numbers you entered:");
            foreach (uint number in numberArray)
            {
                Console.Write("{0} \t",number);
            }
        }

        private static uint EnterNumber(uint lastnum)
        {
            Console.Write("\nEnter your number, Must be > {0}: \t", lastnum);
            return uint.Parse(Console.ReadLine());
        }
    }
}
