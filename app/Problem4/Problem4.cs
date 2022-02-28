using System;
using System.Diagnostics;

namespace app{
    public class Problem4{

        //* A: Main Method - .Run()
        public static string Run(){
            int highestPalindrome = 0;

            for(int num1 = 1; num1 < 1000; num1++){
                for(int num2 = 1; num2 < 1000; num2++){
                    int currentNum = num1 * num2;
                    if(currentNum > highestPalindrome && IsPalindrome(currentNum.ToString())){
                        highestPalindrome = currentNum;
                    }
                    
                }
            }   


            return "Problem 4 Solution " + highestPalindrome;
        }

        

        //* B: Sub-Methods
        //* 1. isPalindrome(string testString) -> returns bool
        private static bool IsPalindrome(string testString)
        {
            for(int i = 0; i < (int)(testString.Count() / 2); i++){
                if(testString.ElementAt(i) != testString.ElementAt(testString.Count() - i - 1)){
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
            return String.Format("Problem4 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}