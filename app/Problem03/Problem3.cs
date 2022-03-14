using System;
using System.Diagnostics;

namespace app{
    public class Problem3{

        //* A: Main Method - .Run()
        public static string Run(){
            //Initialization of variables
            long baseNum = 600851475143; 
            List<long> primeFactors = new List<long>();

            //* 1. Loop through until baseNum = 1
            while(baseNum > 1){
                bool primeFactorFound = false;

                //*  A. Loop through all numbers until a new prime factor is found 
                for(long testNum = 2; !primeFactorFound; testNum++){
                    //Checks if number is a factor of testNum
                    if(baseNum % testNum == 0){
                        //Checks if the number is prime using 1. IsPrime()
                        if(IsPrime(testNum)){
                            //* I. set primeFactorFound to true
                            primeFactorFound = true;
                            //* II. Add new primeFactor to list
                            primeFactors.Add(testNum);
                            //* III. Divide base number by new primeFactor
                            baseNum = baseNum / testNum;
                        }
                    }        
                }
            }
        
            //* 2. Return largest prime factor
            return "Problem 3 Solution: " + primeFactors.Max(); 
        }        

        //* B: Sub-Methods
        
        //* 1. IsPrime(long possiblePrime) -> bool
        private static bool IsPrime(long possiblePrime)
        {
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

            //Outputs RunTime of .Run() method in format 00:00.0000
            return String.Format("Problem3 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}