using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Process procMain = Process.GetCurrentProcess();
            Console.WriteLine("Main Thread ID{0}, Private memory size{1}", procMain.Id, procMain.PrivateMemorySize64);

            Parallel.For(0, 10,
                   async index => {
                       Process proc = Process.GetCurrentProcess();
                       Thread thread = Thread.CurrentThread;


                       Console.WriteLine("Iteration num {0}, Proc ID{1}, ThreadID{2}, Private Memory Size{3}", index, proc.Id, thread.ManagedThreadId, proc.PrivateMemorySize64);
                       await Task.Delay(10000);
                       Console.WriteLine("Thread finished{0}", index);
                   });

            Console.WriteLine("Main Thread ID{0}, Private memory size{1}", procMain.Id, procMain.PrivateMemorySize64);
        }
    }
}

