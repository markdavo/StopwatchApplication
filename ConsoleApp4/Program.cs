using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System; 

namespace StopwatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type 'Start' to begin the stopwatch, 'Stop' to end or " +
                "'exit' to quit: ");
            var userInput = Console.ReadLine();

            //my variable to run stopwatch
            Stopwatch stopwatch = new Stopwatch();
            bool isStarted = false;
            bool isAlreadyStarted = false; 

            //If userr types exit the progarm will terminate
            while (userInput.ToLower() != "exit")
            {
                if (userInput.ToLower() == "start")
                {
                    //catch mthod if the user types start twice in a row
                    if (isAlreadyStarted)
                    {
                        throw new InvalidOperationException("You can't start the timer once it has been stated");
                    }
                    else
                    {
                        stopwatch.Start();
                        isStarted = true;
                        isAlreadyStarted = true; 
                        Console.WriteLine("Now type 'stop' to end timer or 'start' to reset: ");
                        userInput = Console.ReadLine();
                    }
                }
                else if (userInput.ToLower() == "stop")
                {
                    if (isStarted)
                    {
                        stopwatch.Stop();
                        Console.WriteLine("Now type 'stop' again for new time or 'start' to reset: ");
                        userInput = Console.ReadLine();
                        isAlreadyStarted = false; 
                    }
                    else
                    {
                        Console.WriteLine("You need to start the timer first. Please type 'start'.");
                        Console.Write("Now type start: ");
                        userInput = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You did not type one of the required words. Please try again.");
                    userInput = Console.ReadLine();
                }
            }
        }
    }
}
