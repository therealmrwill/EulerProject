# **Problem 5: Smallest Multiple V1.1**
###### ReadMe Template V2.1


#### A: Status: Complete
    Working Status: FullFunc
    ReadMe Status: Completed
    RunTime Status: NotFullyOptimized

#### B: Problem
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

#### C: Logic Explanations
    Example: 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

    (Potentially infinite loop)
        - In the current solution I use a loop that will always evaluate to true, or an infinite loop
        - In my (limited) coding knowledge this is a big no no for many reasons, but mainly because there a chance the code will never complete
        - However for our scenario I am confident in the fact that this loop will eventually return a value
        - This is because eventually the number (1 * 2 * 3 ... * 20) will occur, breaking this loop
            - This would be true with any range of numbers, meaning that this loop is not truly infinite as long as the range is positive 

#### D: Main Logic Steps
    1. Create an (infinite) loop - !This could be problematic
        A. Check if number is divisible by all possibilities
            I. If true, return value
    
#### E: Additional Classes Used
    No additional classes used

#### F: Sub-Methods
    1. IsDivisibleByRange(int num, int startOdRange, int endOfRange) -> returns bool
        A. Create a loop through all numbers between the start and end of the range
            I. (We go backwards through to speed up our final result)
        B. If our number is not evenly divisible by the testNum, return false
        C. Otherwise, return true

#### G: Current Solution: Tested
    Current solution: Run program.cs line 31

#### H: Current runTime:
   RunTime: 00:01.044