using System;
using System.Diagnostics;

namespace app{
    public class Problem5{

        //* A: Main Method - .Run()
        public static string Run(){
            for(int num = 1; true; num++){
                if(DivisibleByRange(num, 1, 20)){
                    return "Problem 5 Solution: " + num;
                }
            }
        }

        

        //* B: Sub-Methods
        private static bool DivisibleByRange(int num, int startOfRange, int endOfRange)
        {
            for(int testNum = startOfRange; testNum <= endOfRange; testNum++){
                if(num % testNum != 0){
                    return false;
                }
            }

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