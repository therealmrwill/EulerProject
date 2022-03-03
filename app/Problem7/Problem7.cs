using System;
using System.Diagnostics;

namespace app{
    public class Problem7{

        //* A: Main Method - .Run()
        public static string Run(){
            List<long> primes = new List<long>();

            for(long num = 1; primes.Count() < 10001; num++){
                
                if(IsPrime(num)){
                    primes.Add(num);
                }
            }

            return "Problem 7 Solution: " + primes.Max();
        }

        //* B: Sub-Methods
        //* 1. IsPrime(long possiblePrime) -> bool
        private static bool IsPrime(long possiblePrime)
        {
            if(possiblePrime <= 1){
                return false;
            }

            //* a. Sets maximum testing value to sqrt(possiblePrime)
            long max = (long)Math.Sqrt(possiblePrime);

            //* b. Tests every number between 2 and maximum
            for(int testValue = 2; testValue <= max; testValue++){
                //* I. If testValue is a factor of possiblePrime return false
                if(possiblePrime % testValue == 0){
                    return false;
                }
            }

            //* c. Otherwise return true
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
            return String.Format("Problem(numHere) RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}