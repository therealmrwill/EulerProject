using System;
using System.Diagnostics;

namespace app{
    public class Problem2{

        //* A: Main Method - .Run()
        public static string Run(){
            //* 1. Instantiate Variables
            List<int> allFibNums = new List<int>();
            long evenFibSum = 2;

            //* 2. Add 1 and 2 to Fibonacci List
            allFibNums.Add(1);
            allFibNums.Add(2);

            //* 3. For loop until max value of allFibNums > 4,000,000
            for(int i = 2; allFibNums.Max() <= 4000000; i++){
                int newFib = allFibNums[i - 1] + allFibNums[i - 2];

                //* 3a. Add new Fibonacci value to allFibNums
                allFibNums.Add(newFib);

                //* 3b. If new number is even add to evenFibSum
                if(newFib % 2 == 0){
                    evenFibSum += newFib;
                }

            }

            //* $. Return evenFibSum
            return "Solution to problem 2: " + evenFibSum;
        }

        //* B: Sub-Methods
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
            return String.Format("Problem2 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}