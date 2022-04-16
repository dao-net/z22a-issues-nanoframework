using nanoFramework.TestFramework;
using System;
using System.Threading;

namespace SetupAndCleanupNotRun.NFUnitTest1
{




	[TestClass]
	public class Test1
	{
		public static bool Initialized = false;

		[Setup]
		public static void RunSetup()
		{
			Thread.Sleep(2000);
			Console.WriteLine("Setup");
		}

		[Cleanup]
		public static void Cleanup()
		{
			Thread.Sleep(2000);
			Console.WriteLine("Cleanup");
			Assert.False(Initialized); // should throw an exception because Initialized was nowhere set to true, bu´t doesn't.   
		}

		[TestMethod]
		public void TestMethod1()
		{
			Thread.Sleep(2000);
			Console.WriteLine("(Prior to this line 'Startup' should have been output - see line 14).");
			Console.WriteLine(DateTime.UtcNow.ToString());
			Console.WriteLine("(After to this line 'Cleanup' should be printed - see line 20).");
		}
	}
}
