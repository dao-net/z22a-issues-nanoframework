using nanoFramework.TestFramework;
using System;
using System.Threading;

namespace SetupAndCleanupNotRun.NFUnitTest1
{
	[TestClass]
	public class Test1
	{
		public static int counter = 0;

		[Setup]
		public static void RunSetup()
		{
			Console.WriteLine($"Setup {counter++}");
			Console.WriteLine(DateTime.UtcNow.ToString());
		}

		[Cleanup]
		public static void Cleanup()
		{
			Console.WriteLine($"Cleanup {counter++}");
			Console.WriteLine(DateTime.UtcNow.ToString());
		}

		[TestMethod]
		public void TestMethod1()
		{
			Console.WriteLine($"TestMethod1 {counter++}");
			Console.WriteLine(DateTime.UtcNow.ToString());
		}

		[TestMethod]
		public void TestMethod2()
		{
			Console.WriteLine($"TestMethod2 {counter++}");
			Console.WriteLine(DateTime.UtcNow.ToString());
		}
	}
}
