using System;
using System.Diagnostics;
using System.Threading;

namespace stopwatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
            }
            stopwatch.Stop();
            Console.WriteLine("elapse time:{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
        
    }
}