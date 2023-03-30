## Problem 1: Multiples of 3 or 5 


**Problem Status**

    C#: Completed - CSharp_Implementation/Problem1/Problem1.cs
    Java: Not Started 
    JavaScript: Not Started
    Python: Not Started

**Statement of Problem**

    Background: 
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    The sum of these multiples is 23.

    Goal:
    Find the sum of all the multiples of 3 or 5 below 1000.


**Main Pseudo-Code**

    1. Create a variable labeled "sum" to store the sum our found multiples
    2L. Create a looping value (currentNum) that starts at 1, and ending right below 1,000 (999)
        2.1? Check if currentNum is a multiple of 3 or 5
            2.1 True - Add our currentNum to the sum
            2.2 False - Do nothing, and continue to the next number
    3. Return the sum value - this is our answer 

**Logic Explanations**

    *Finding a multiple of a number
        To find a multiple of a number, we can use a tool called modulo (%)
        Modulo returns the remainder of a division 
            Ex. 12 % 3 = 0 , 13 % 3 = 1
        Using this, we know that if x % 3 = 0, the number is a multiple of 3
            Because there is no remainder, meaning 3 evenly divides x






