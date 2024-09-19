using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Example
{
	public class Test
	{
		public static async void Method1()
		{
			await Task.Run(() =>
			{
				for (int i = 0; i < 5; i++)
				{
					Console.WriteLine($"Method1: {i}");
				}
			});
			
		}
		public static void Method2()
		{
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine($"Method2: {i}");
			}
		}
	}

	public class Program
	{
		
		public static void Main()
		{
			Test.Method1();
			Test.Method2();

		}
	}
}