# **Problem 7: 10,001st Prime V1.1**
###### ReadMe Template V2.1


#### A: Status: Completed
    Working Status: FullFunc
    ReadMe Status: Completed
    RunTime Status: Optimized

#### B: Problem
    What is the 10,001st prime number?

#### C: Logic Explanations
    Test Case: First 6 prime numbers
        - 2, 3, 5, 7, 11, 13

    More on Prime numbers in Problem 3

#### D: Main Logic Steps
    1. Create an empty list to store primes in
    2. Create a loop to run until 10,001 primes have been found 
        A. Check if current number is prime using IsPrime()
        B. Add number to prime list if it is
    3. Return the highest prime (which will be the 10,001st prime)

#### E: Additional Classes Used
    No Additional Classes Used

#### F: Sub-Methods
    1. IsPrime(long possiblePrime) -> returns bool (V2.0)
        a. If value is anything below 2 it is automatically returned as not prime
        b. Sets maximum testing value to sqrt(possiblePrime)
        c. Tests every number between 2 and maximum
            I. If testValue is a factor of possiblePrime return false
        d. Otherwise return true
            I. This means that there are no factors other than 1 and the number

#### G: Current Solution: Not-Tested
    Solution: Run line 39 of Program.cs

#### H: Current runTime:
    Runtime: 00:00.007


