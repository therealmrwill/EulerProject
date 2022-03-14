# **Problem 9: Special Pythagorean Triplet V2.2*
###### ReadMe Template V2.1


#### A: Status: Completed
    Working Status: FullFunc
    ReadMe Status: Completed
    RunTime Status: Optimized

#### B: Problem
    - There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    - Find the product abc.

#### C: Logic Explanations
    Given Information:
        - A, B, and C are all natural numbers
        - A^2 + B^2 = C^2
        - A + B + C = 1,000
        - A < B < C

    Proven Information: (All proofs in code file)
        - Given A
            1. B = (2000A - 1,000,000) / (2A - 2000)
            2. C = Sqrt(A^2 + B^2)
        - Max of A
            - A can be no larger than 1000 / 3


#### D: Main Logic Steps
    1. Loop through all possible values of a (our smallest number)
        A. Find the b value (our second largest number)
        B. Find the c value (our largest value)
        C. Check if b is a natural number
            Ia. This means that c is also a natural number so we don't have to check
            Ib. If b is natural, return our total (a * b * c)

#### E: Additional Classes Used
    No additional classes used! 

#### F: Sub-Methods
    No additional Sub-Methods Used

#### G: Current Solution: Correct
    Solution: Line 47 in program.cs

#### H: Current runTime:
    Current Runtime: 00:00.007

