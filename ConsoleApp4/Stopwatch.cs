using System;

namespace StopwatchApp
{
    public class Stopwatch
    {
        DateTime startTime; 
        DateTime endTime; 

        public void Start()
        {
            startTime = DateTime.Now; 
        }

        public void Stop()
        {
            endTime = DateTime.Now;
            TimeSpan elpasedTime = endTime - startTime;
            Console.WriteLine("The following "+elpasedTime+" has elpased");
        }
    }
}
