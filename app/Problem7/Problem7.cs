using System;
using System.Diagnostics;

namespace app{
    public class Problem7{

        //* A: Main Method - .Run()
        public static string Run(){
            //* 1. Create an empty list to store primes in
            List<long> primes = new List<long>();

            //* 2. Create a loop to run until 10,001 primes have been found 
            for(long num = 1; primes.Count() < 10001; num++){
                //* A. Check if current number is prime using IsPrime()
                if(IsPrime(num)){
                    //* B. Add number to prime list if it is
                    primes.Add(num);
                }
            }

            //* 3. Return the highest prime (which will be the 10,001st prime)
            return "Problem 7 Solution: " + primes.Max();
        }

        //* B: Sub-Methods
        //* 1. IsPrime(long possiblePrime) -> bool
        //V2.0
        private static bool IsPrime(long possiblePrime)
        {
            //* a. Returns false if value is less that 2
            if(possiblePrime <= 1){
                return false;
            }

            //* b. Sets maximum testing value to sqrt(possiblePrime)
            long max = (long)Math.Sqrt(possiblePrime);

            //* c. Tests every number between 2 and maximum
            for(int testValue = 2; testValue <= max; testValue++){
                //* I. If testValue is a factor of possiblePrime return false
                if(possiblePrime % testValue == 0){
                    return false;
                }
            }

            //* d. Otherwise return true
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
            return String.Format("Problem 7 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}