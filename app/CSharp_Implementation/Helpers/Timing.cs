using System;
namespace EulerTests.Helper
{
	public static class Timing
	{
		public static long GetTicks<T>(Func<T> method) {
			long startTime = DateTime.Now.Ticks;

			method();

			long endTime = DateTime.Now.Ticks;
			return endTime - startTime;
		}
	}
}

