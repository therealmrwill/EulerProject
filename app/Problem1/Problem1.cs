using System;
using System.Diagnostics;

namespace app
{
    public class Problem1
    {
        //* A: Main Method - .Run()
        public static string Run(){
            //* 1. Create totalSum Variable
            int totalSum = 0;

            //* 2. Loop through nums 1-999
            for(int num = 1; num < 1000; num++){
                //* 2a. If num is a multiple of 3 or 5, add it to the totalSum
                if(num % 3 == 0 || num % 5 == 0){
                    totalSum = totalSum + num;
                }
            }

            //* 3. Return TotalSum
            return "Solution to Problem 1: " + totalSum;
        }

        //* B: Sub Methods
        //There are no Sub-Methods for this problem!

        //* C: RunTime Method - .RunTime()
        public static string RunTime(){
        //Creates a stopwatch object
        Stopwatch stopwatch = new Stopwatch();
 
        //Starts the stopwatch
        stopwatch.Start();

        //Runs current .Run() method
        Run();
    
        //Stops the stopwatch
        stopwatch.Stop();
 
        //Creates TimeSpan object with stopwatch data
        TimeSpan ts = stopwatch.Elapsed;

        //Outputs RunTime of .Run() method in format 00:00.000
        return String.Format("Problem1 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }
    }   
}