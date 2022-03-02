using System;
using System.Diagnostics;

namespace app{
    public class Problem5{

        //* A: Main Method - .Run()
        public static string Run(){

            //* 1. Create an "infinite" loop
            //? See documentation for my reasoning
            //Edit: To further optimize the speed of the program, I am incrementing by the highest number in the range 
            // ^ This works because any possible solution would have to be divisible by this number anyways
            for(int num = 0; true; num = num + 20){
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
            //* A. If number = 0 return false
            if(num == 0){
                return false;
            }

            //* B. Create a loop through all numbers between the start and end of the range
            for(int testNum = endOfRange; testNum >= startOfRange; testNum--){
                //* C. If our number is not evenly divisible by the testNum, return false
                if(num % testNum != 0){
                    return false;
                }
            }

            //* D. Otherwise, it is divisible by all numbers in the range, so we return true
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