using System;
using System.Diagnostics;

namespace app{
    public class Problem8{

        //* A: Main Method - .Run()
        public static string Run(){
            string dataString = System.IO.File.ReadAllText(@"Problem8/Problem8Data.txt");
            List<int> dataList = NumListFromString(dataString);
            long maxProduct = 0;

            for(int begNum = 0; begNum < dataList.Count() - 14; begNum++){
                long curProduct = 1;
                
                for(int curNum = 0; curNum < 13; curNum++){
                    long nuwMultiple = dataList.ElementAt(begNum + curNum);
                    curProduct *= nuwMultiple;
                }

                if(curProduct > maxProduct){
                    maxProduct = curProduct;
                }
            }

            return "Problem 8 solution: " + maxProduct;
            
        }

        

        //* B: Sub-Methods
        private static List<int> NumListFromString(string dataString)
        {
            List<int> dataOut = new List<int>();
            int num = 0;

            for(int charNum = 0; charNum < dataString.Count() - 1; charNum++){
                if(int.TryParse(dataString.Substring(charNum, 1), out num)){
                    dataOut.Add(int.Parse(dataString.Substring(charNum, 1)));
                }
            }

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