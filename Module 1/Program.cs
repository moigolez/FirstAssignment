﻿using System;

namespace Module_1
{
	class Program
	{
		static void Main()
		{
			ConcatanationOfStrings("my first string", " My second string");
		}
		static void ConcatanationOfStrings(string parameter1, string parameter2)
		{
			string result = parameter1 + "" +parameter2;

			Console.WriteLine(result);
		}
	}
}
