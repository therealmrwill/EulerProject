# **Problem 3: Largest Prime Factor V1.4**
###### ReadMe Template V2.1


#### A: Status: Complete 
    Working Status: FullFunc
    ReadMe Status: Completed
    RunTime Status: Optimized

#### B: Problem
    Find the largest prime factor of the number: 600851475143

#### C: Logic Explanations
    Finding Prime Factors:
        1. Find lowest prime that evenly divides into number
        3. Divide number by said prime
        4. Repeat until number = 0

    Finding Factors
        1. All Factors come in pairs (X * Y = Number)
        2. To find all factors, we only have to check numbers under the sqrt of our number
        3. Because any number above the sqrt will have it's pair below the square root

    Finding Primes:
        1. If the number has any factors between 2 and sqrt(Number) then it is not prime
        

#### D: Main Logic Steps
    1. Loop through until baseNum = 1
        A. Loop through all numbers until a new prime factor is found 
        I. set primeFactorFound to true
            II. Add new primeFactor to list
            III. Divide base number by new primeFactor
    2. Return largest prime factor

#### E: Additional Classes Used
    No Additional Classes Used

#### F: Sub-Methods
    1. IsPrime(long possiblePrime) -> returns bool
        a. Sets maximum testing value to sqrt(possiblePrime)
        b. Tests every number between 2 and maximum
            I. If testValue is a factor of possiblePrime return false
        c. Otherwise return true
            I. This means that there are no factors other than 1 and the number

#### G: Current Solution: Not-Tested
    Solution: Run Line 23 of Program.cs

#### H: Current runTime:
    Output: 00:00.033
    

