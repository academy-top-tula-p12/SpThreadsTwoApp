using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpThreadsTwoApp
{
    internal class Examples
    {
        static int count = 0;
        public static void LockMutexEvents()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new(CountInc);
                thread.Name = $"Thread {i + 1}";
                thread.Start();
            }
        }

        static void CountInc()
        {

            for (int i = 0; i < 100000; i++)
            {
                // LOCK
                //lock (locker)
                //{
                //    count++;
                //}

                // MONITOR
                //Monitor.Enter(locker);
                //count++;
                //Monitor.Exit(locker);

                // MUTEXT
                //mutex.WaitOne();
                //count++;
                //mutex.ReleaseMutex();

                // RESET EVENT
                //waitHandler.WaitOne();
                //count++;
                //waitHandler.Set();

                //Console.WriteLine($"{Thread.CurrentThread.Name} - {count}");
                //Thread.Sleep(1);
            }
            Console.WriteLine($"{Thread.CurrentThread.Name} - {count}");

        }
    }
}
