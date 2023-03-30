using System;
namespace EulerTests.Helper
{
	public abstract class BaseProblem<T> : IProblem<T>
	{
        public long TickSpeed { get => Timing.GetTicks(Solution); }
        public string ProblemName;
        public int ProblemNum;


		public BaseProblem(string problemName, int problemNum, bool enabled)
		{
            ProblemName = problemName;
            ProblemNum = problemNum;
            PrintSolution(enabled);
		}

        public void PrintSolution(bool timed)
        {
            string solution = $"\nProblem {ProblemNum} ({ProblemName}): ";

            solution += $"\n   Answer: {Solution()}";
            if (timed) solution += $"\n   Time (Ticks): {TickSpeed}";


            Console.Write(solution);
        }

        public abstract T Solution();
    }
}

