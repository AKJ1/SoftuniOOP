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

        public void Start()
        {
            for (int i = 0; i < this.ticks; i++)
            {
                Thread.Sleep(this.milliseconds);
                action();
            }
        }
        public static void PrintToConsole()
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
            Action action = delegate() { PrintToConsole(); };
            AsyncTimer doStuff = new AsyncTimer(action, 3, 1000);
            doStuff.Start();
        }
    }
}
