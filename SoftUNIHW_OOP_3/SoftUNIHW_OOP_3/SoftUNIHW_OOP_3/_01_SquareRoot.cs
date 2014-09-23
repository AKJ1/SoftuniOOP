using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_3
{
    class SquareRoot
    {
        public static void GetSQRT()
        {
            try
            {
                Console.WriteLine("Please enter an integer");
                uint x = uint.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(x));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Number");
                Console.ForegroundColor = ConsoleColor.Gray;
                throw;
                
            }
            finally
            {
                Console.WriteLine("Good Bye!");
            }
        }
    }
}
