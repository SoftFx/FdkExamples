﻿namespace DataClientExamples
{
    using System;
    using SoftFX.Extended;

	class TestTradeConnectionExample
	{
		public static void Run()
		{
			var buidlers = ConnectionStringBuilder.TestTradeConnections("ttdemo.fxopen.com", "59932", "8mEx7zZ2");
			//var builders = FixConnectionStringBuilder.TestTradeConnections("ttdemo.fxopen.com", "59932", "8mEx7zZ2");;
			Console.WriteLine("buildes.Length = {0}", buidlers.Length);
		}
	}
}
