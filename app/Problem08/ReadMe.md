# **Problem 8: Largest product in a series V1.1**
###### ReadMe Template V2.1


#### A: Status: Completed
    Working Status: FullFunc
    ReadMe Status: Completed
    RunTime Status: NotOptimized

#### B: Problem
    Find the value of the thirteen adjacent digits in the 1000-digit number that have the greatest product.

#### C: Logic Explanations
    Data for this project can be found here:
        - app/Problem8/Problem8Data.txt

#### D: Main Logic Steps
    1. Read the data in from the file
    2. Turn it into a list of numbers
    3. Create a loop to loop through all the possible 13 digit combinations
        A. Multiply all numbers in current combination
        B. Check if the current product is larger than the current largest product
    4. Output the largest product


#### E: Additional Classes Used
    No additional classes used

#### F: Sub-Methods
    1. NumListFromString(string dataString) -> returns List<int>
        A. Loop through all characters in the string
            I. If the character is a number, add it to the number list
        B. Return the completed number list

#### G: Current Solution: Not-Tested
    Solution: Run Program.cs line 43

#### H: Current runTime:
    RunTime: 00:00.024


