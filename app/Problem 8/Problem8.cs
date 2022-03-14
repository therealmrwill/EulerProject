using System;
using System.Diagnostics;

namespace app{
    public class Problem8{

        //* A: Main Method - .Run()
        public static string Run(){
            //* 1. Read the data in from the file
            string dataString = System.IO.File.ReadAllText(@"Problem8/Problem8Data.txt");
            //* 2. Use Method 1 to turn it into a list of numbers
            List<int> dataList = NumListFromString(dataString);
            long maxProduct = 0;

            
            //* 3. Loop through all 13 digit combinations
            for(int begNum = 0; begNum < dataList.Count() - 14; begNum++){
                long curProduct = 1;
                
                //* A. Multiply all numbers in the current combination
                for(int curNum = 0; curNum < 13; curNum++){
                    long nuwMultiple = dataList[begNum + curNum];
                    curProduct *= nuwMultiple;
                }

                //* B. If current product is bigger than the max, set this number as the max
                if(curProduct > maxProduct){
                    maxProduct = curProduct;
                }
            }

            //* 4. Output the largest product
            return "Problem 8 solution: " + maxProduct;


        
            
        }

        

        //* B: Sub-Methods
        private static List<int> NumListFromString(string dataString)
        {
            List<int> dataOut = new List<int>();
            int num = 0;

            //* A. Loop through all characters in dataString
            for(int charNum = 0; charNum < dataString.Count() - 1; charNum++){
                //* I. If the character is a number, add it to the number list
                if(int.TryParse(dataString.Substring(charNum, 1), out num)){
                    dataOut.Add(int.Parse(dataString.Substring(charNum, 1)));
                }
            }

            //* B. Return the completed number list
            return dataOut;
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
            return String.Format("Problem 8 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

    }
}