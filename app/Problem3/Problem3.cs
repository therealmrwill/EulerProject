using System;
using System.Diagnostics;

namespace app{
    public class Problem3{

        //* A: Main Method - .Run()
        public static string Run(){
            long baseNum = 600851475143; 
            List<long> primeFactors = new List<long>();

            while(baseNum > 1){
                bool primeFound = false;

                for(long testNum = 2; !primeFound; testNum++){
                    if(baseNum % testNum == 0){
                        if(IsPrime(testNum)){
                            primeFound = true;
                            primeFactors.Add(testNum);
                            baseNum = baseNum / testNum;
                        }
                    }        
                }
            }
        
            return "Problem 3 Solution: " + primeFactors.Max(); 
        }        

        //* B: Sub-Methods
        private static bool IsPrime(long possiblePrime)
        {
            long max = (long)Math.Sqrt(possiblePrime);

            for(int testValue = 2; testValue <= max; testValue++){
                if(possiblePrime % testValue == 0){
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

            //Outputs RunTime of .Run() method in format 00:00.0000
            return String.Format("Problem3 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}