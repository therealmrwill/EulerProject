using System;
using System.Diagnostics;

namespace app{
    public class Problem6{

        //* A: Main Method - .Run()
        public static string Run(){
            double sumOfSquares = 0;
            double sumOfNumbers = 0;

            for(int num = 1; num <= 100; num++){
                sumOfNumbers += num;
                sumOfSquares += Math.Pow(num, 2);
            }

            double difference = Math.Pow(sumOfNumbers, 2) - sumOfSquares;
            return "Problem 6 solution: " + difference; 
        }

        //* B: Sub-Methods
        //There are no Sub-Methods for this problem!

        //* C: RunTime Method - .RunTime()
        public static string RunWithTime(){
            //Creates a stopwatch object
            Stopwatch stopwatch = new Stopwatch();
    
            //Starts the stopwatch
            stopwatch.Start();

            //Runs current .Run() method
            System.Console.WriteLine(Run());
        
            //Stops the stopwatch
            stopwatch.Stop();
    
            //Creates TimeSpan object with stopwatch data
            TimeSpan ts = stopwatch.Elapsed;

            //Outputs RunTime of .Run() method in format 00:00.000
            return String.Format("Problem 6 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}