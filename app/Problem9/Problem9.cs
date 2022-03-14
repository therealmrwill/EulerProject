using System;
using System.Diagnostics;

namespace app{
    public class Problem9{

        //* A: Main Method - .Run()
        public static string Run(){
            //Non-Optimized solution

            for(int a = 1; a <= 1000; a++){
                for(int b = 1; a + b <= 1000; b++){
                    for(int c = 1; a + b + c <= 1000; c++){
                        if(Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2) && a + b + c == 1000){
                            return "Answer: " + (a * b * c) + 
                            "\nA: " + a + " B: " + b + " C: " + c;
                        }
                    }
                }
            }

            // a = sqrt (c^2 - b^2)
            // Largest possible a + b
            // Largest possible c
            //a + b + c < 1000
            // a + b < 1000 - c
            // c < 1000 - a - b
            
            

            return "UnFished Business";
        }

        //* B: Sub-Methods
        //There are no Sub-Methods for this problem!

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
            return String.Format("Problem 9 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}