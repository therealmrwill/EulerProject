using System;
using System.Diagnostics;

namespace app{
    public class Problem9{

        //* A: Main Method - .Run()
        public static string Run(){
            //* Logic:
            //Given: a + b + c = 1000
            //Given: a^2 + b^2 = c^2
            //Given: a < b < c

            //* Variables given A
                //* 1. Finding B
                    //A:  b = 1000 - a - c
                    //B:  c = sqrt(a^2 + b^2)
                    //C:  b = 1000 - a - sqrt(a^2 + b^2)
                    //D:  1000 - a - b = sqrt(a^2 + b^2) 
                    //E:  (1000 - a - b)^2 = a^2 + b^2
                    //F:  a^2 - 2000a - 2000b+ 2ab + b^2 + 1,000,000 = a^2 + b^2
                    //G:  -2000a - 2000b + 2ab + 1,000,000 = 0
                    //H:  -2000b + 2ab = 2000a - 1,000,000
                    //I:  b(-2000 + 2a) = 2000a - 1,000,000
                    //J:  b = 2000a - 1,000,000 / (2a - 2000)
                //* 2. Finding C
                    //A: a^2 + b^2 = c^2
                    //B: c = sqrt(a^2 + b^2)
            //* Max A value
                //a < b < c
                // This means our largest a would have to be less than 1000 / 3
                //Because if a = b = c, a's max would be 1000/3

            //* 1. Loop through all possible values of a (our smallest number)
            for(double a = 1; a < 1000 / 3; a++){

                //* A. Find the b value (our second largest number)
                double b = ((2000 * a) - 1000000) / ((2 * a) - 2000);

                //* B. Find the c value (our largest value)
                double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));

                //* C. Check if b is a natural number
                if(b % 1 == 0){
                    //* I. If b is natural, return our answer
                    double total = a * b * c;
                    return "Problem 9 Solution: " + total;
                }
            }

            
            
            return "Error: No Natural Number combination found";
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