using System;
using System.Diagnostics;

namespace app{
    public class Problem11{

        //* A: Main Method - .Run()
        public static string Run(){
            string[] dataStrings = System.IO.File.ReadAllLines(@"Problem11/DataSet.txt");
            List<List<int>> dataLists = new List<List<int>>();

            for(int i = 0; i < dataStrings.Count(); i++){
                dataLists.Add(NumListFromString(dataStrings[i]));
            }

            int maxProduct = 0;
            if(maxProduct < MaxFromHorizontal(dataLists)){
                maxProduct = MaxFromHorizontal(dataLists);
            }

            if(maxProduct < MaxFromVertical(dataLists)){
                maxProduct = MaxFromVertical(dataLists);
            }

            return maxProduct.ToString();
        }

        private static int MaxFromVertical(List<List<int>> dataLists)
        {
            int max = 0;

            for(int columns = 0; columns < dataLists.Count(); columns++){
                for(int rows = 0; rows < dataLists.Count() - 3; rows++){
                    int tempMax = 1;
                    List<int> testNums = new List<int>();
                    for(int testIterator = 0; testIterator < 4; testIterator++){
                        tempMax *= dataLists[rows + testIterator][columns ];
                        testNums.Add(dataLists[rows + testIterator][columns]);
                    }

                    if(tempMax > max){
                        max = tempMax;
                    }
                }
            }


            return max;
        }

        private static int MaxFromHorizontal(List<List<int>> dataLists)
        {
            int max = 0;

            for(int rows = 0; rows < dataLists.Count(); rows++){
                for(int columns = 0; columns < dataLists.Count() - 3; columns++){
                    int tempMax = 1;
                    //List<int> testNums = new List<int>();
                    for(int testIterator = 0; testIterator < 4; testIterator++){
                        tempMax *= dataLists[rows][columns + testIterator];
                        //testNums.Add(dataLists[rows][columns + testIterator]);
                    }

                    if(tempMax > max){
                        max = tempMax;
                    }
                }
            }


            return max;
        }

        //* B: Sub-Methods
        private static List<int> NumListFromString(string dataString)
        {
            List<int> dataOut = new List<int>();
            int num = 0;

            //* A. Loop through all numbers in dataString
            for(int charNum = 0; charNum < dataString.Count() - 1; charNum += 3){
                //* I. If the character is a number, add it to the number list
                if(int.TryParse(dataString.Substring(charNum, 2), out num)){
                    dataOut.Add(int.Parse(dataString.Substring(charNum, 2)));
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
            return String.Format("Problem 11 RunTime is {0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);

        }

    }
}