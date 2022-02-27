# **Problem 3: Largest Prime Factor V1.3**
###### ReadMe Template V2.1


#### A: Status: Incomplete
    Working Status: FullFunc
    ReadMe Status: N/A
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
    1. Add Steps Here

#### E: Additional Classes Used
    No Additional Classes Used

#### F: Sub-Methods
    1. IsPrime(lone possiblePrime) -> returns bool
        1a. 

#### G: Current Solution: Not-Tested
    Put Current Solution Here

#### H: Current runTime:
    Output: 00:00.0007229
    - Time is less than .000 so it is not displayed with .RunWithTime() method

