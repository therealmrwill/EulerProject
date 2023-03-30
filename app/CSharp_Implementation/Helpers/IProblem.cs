using System;
namespace EulerTests.Helper
{
	public interface IProblem<T>
	{
		public long TickSpeed { get; }

		public T Solution();

		public void PrintSolution(bool timed);
	}
}

