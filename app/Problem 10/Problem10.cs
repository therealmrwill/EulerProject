using System;
using System.Diagnostics;

namespace app{
    public class Problem10{

        //* A: Main Method - .Run()
        public static string Run(){
            long primeTotal = 0;

            //* 1. Loop through all numbers under 2 Million (2,000,000)
            for(long possiblePrime = 0; possiblePrime < 2000000; possiblePrime++){
                //* A. Check if number is prime using PrimeChecker
                if(IsPrime(possiblePrime)){
                    //* I. If it is, add it to primeTotal
                    primeTotal += possiblePrime;
                }
            }

            //* Output the prime total
            return "Problem 10 Solution: " + primeTotal;
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
            return String.Format("Problem 10 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}