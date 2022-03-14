# **Problem 10: Summation of Primes V1.1**
###### ReadMe Template V2.1


#### A: Status: Incomplete
    Working Status: FullFunc
    ReadMe Status: Complete
    RunTime Status: NotOptimized

#### B: Problem
    Find the sum of all the primes below two million.

#### C: Logic Explanations
    Test Case: 
        - The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    IsPrime method used from Problem 7

#### D: Main Logic Steps
    1. Loop through all numbers under 2 Million (2,000,000)
        A. Check if number is prime using PrimeChecker
            I. If it is, add it to primeTotal
    2. Output the prime total
        

#### E: Additional Classes Used
    No Additional Classes used!

#### F: Sub-Methods
    1. IsPrime(long possiblePrime) -> returns bool (V2.0)
        a. If value is anything below 2 it is automatically returned as not prime
        b. Sets maximum testing value to sqrt(possiblePrime)
        c. Tests every number between 2 and maximum
            I. If testValue is a factor of possiblePrime return false
        d. Otherwise return true
            I. This means that there are no factors other than 1 and the number

#### G: Current Solution: Correct
    Solution: Line 51 of Program.cs

#### H: Current runTime:
    Current RunTime: 00:00.300

