# **Problem 4: Largest palindrome product V2.0**
###### ReadMe Template V2.1


#### A: Status: Completed
    Working Status: FullFunc
    ReadMe Status: Completed
    RunTime Status: Optimized

#### B: Problem
    Find the largest palindrome made from the product of two 3-digit numbers.

#### C: Logic Explanations
    Palindrome:
        - A string that reads the same forwards or backwards
        - Ex. 'RACECAR' 'TACOCAT' '9009'

    Testing Palindromes
        - Compare first half of characters to second half    

#### D: Main Logic Steps
    1. Create 2 loops to check all products from 100 to 999
    2. If the product is more than the current palindrome and number is a palindrome record value as new highest palindrome
    3. Return the highest found palindrome


#### E: Additional Classes Used
    No Additional Classes Used

#### F: Sub-Methods
    1. isPalindrome(string testString) -> returns bool
        a. Set max value to half of the strings length (rounding down)
        b. Loop through from 0 to max
            I. If character at i doesn't equal its pair return false
                Ex: '12031' 
                    - Pair 0: 1 and 1
                    - Pair 1: 2 and 3 returns false
        c. If string passes all tests, return true

#### G: Current Solution: Not-Tested
    Solution: Run line 27 in Program.cs

#### H: Current runTime:
    runTime: 00:00.017

