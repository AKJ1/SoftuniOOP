using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_5
{
    class AsyncTimer
    {
        private Thread thread;
        private Action action;
        private int ticks;
        private int milliseconds = 1000;

        public void WaitForSeconds(int times)
        {
            for (int i = 0; i <= times; i++)
            {
                Thread.Sleep(milliseconds);   
                PrintToConsole();
            }
        }

        public void PrintToConsole()
        {
            Console.WriteLine("If everything wnt right, a second went by since the last write.");
        }

        AsyncTimer(Action action, int ticks, int ms)
        {
            this.action = action;
            this.ticks = ticks;
            this.milliseconds = ms;
        }
        public static void Tester()
        {
            
        }
    }
}
