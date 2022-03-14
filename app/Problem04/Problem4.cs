using System;
using System.Diagnostics;

namespace app{
    public class Problem4{

        //* A: Main Method - .Run()
        public static string Run(){
            int highestPalindrome = 0;

            //* 1. Create 2 loops to check all products from 100 to 999
            for(int num1 = 100; num1 < 1000; num1++){
                for(int num2 = 100; num2 < 1000; num2++){
                    //Product of 2 numbers
                    int currentNum = num1 * num2;

                    //* 2. If the product is more than the current palindrome and number is a palindrome record value as new highest palindrome
                    if(currentNum > highestPalindrome && IsPalindrome(currentNum.ToString())){
                        highestPalindrome = currentNum;
                    }
                    
                }
            }   

            //* 3. Return the highest found palindrome
            return "Problem 4 Solution " + highestPalindrome;
        }

        

        //* B: Sub-Methods
        //* 1. isPalindrome(string testString) -> returns bool
        private static bool IsPalindrome(string testString)
        {
            //* a. Set max value to half of the strings length (rounding down)
            int max = (int)(testString.Count() /2);

            //* b. Loop through from 0 to ma
            for(int i = 0; i <= max; i++){

                //* I. If character at i doesn't equal its pair return false
                if(testString.ElementAt(i) != testString.ElementAt(testString.Count() - i - 1)){
                    return false;
                }
            }

            //* If string passes all tests, return true
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