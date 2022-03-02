using System;
using System.Diagnostics;

namespace app{
    public class Problem5{

        //* A: Main Method - .Run()
        public static string Run(){

            //* 1. Create an "infinite" loop
            //? See documentation for my reasoning
            for(int num = 1; true; num++){

                //* 2. Check if number is divisible by all numbers in a range using IsDivisibleByNumber()
                if(IsDivisibleByRange(num, 1, 20)){
                    //* 3. If true, return the value
                    //This also ends the code, breaking our "infinite" loop
                    return "Problem 5 Solution: " + num;
                }
            }
        }

        

        //* B: Sub-Methods
        private static bool IsDivisibleByRange(int num, int startOfRange, int endOfRange)
        {
            //* A. Create a loop through all numbers between the start and end of the range
            for(int testNum = endOfRange; testNum >= startOfRange; testNum--){
                //* B. If our number is not evenly divisible by the testNum, return false
                if(num % testNum != 0){
                    return false;
                }
            }

            //* C. Otherwise, it is divisible by all numbers in the range, so we return true
            return true;
        }

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
            return String.Format("Problem 5 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}