
	using System;
	using System.Diagnostics;
	using System.Threading.Tasks;

namespace StopWatch
{ 
	class StopwatchTimer
	{
		static void Main()
		{
			Console.WriteLine("Press Enter to START THE TIMER");
			Stopwatch timer = new Stopwatch();
			Console.ReadLine();

			timer.Start();

			Console.WriteLine("TIMER RUNNING!!,  Press Enter to STOP");
			Console.ReadLine();
			timer.Stop();



			Console.WriteLine("Time elapsed: " + timer.Elapsed);
		}
	}
}