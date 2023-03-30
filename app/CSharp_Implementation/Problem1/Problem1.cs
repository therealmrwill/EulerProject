namespace EulerTests.CSharpProblem;

using EulerTests.Helper;



class Problem1 : BaseProblem<int>
{
    public Problem1(bool timed = true) : base("Multiples of 3 or 5", 1, timed) {}

    public override int Solution()
    {
        int maxValue = 1000;
        int minValue = 1;

        int sum = 0;

       for(int currentNum = minValue; currentNum < maxValue; currentNum++){
            if(currentNum % 3 == 0){
                sum = sum + currentNum;
            }   
            else if(currentNum % 5 == 0){
                sum += currentNum;
            }

       }


       return sum;
    }
}