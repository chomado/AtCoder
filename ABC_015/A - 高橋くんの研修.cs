// A - 高橋くんの研修
// http://abc015.contest.atcoder.jp/tasks/abc015_1
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ChomadoAtCoder
{
	class Chomado
	{
		public Chomado() {}
		public static int Main()
		{
			new Chomado().Calc ();
			return 0;
		}

		string[] InputValues
		{
			get { 
				return new [] { Console.ReadLine(), Console.ReadLine() };
			}
		}
		void Calc()
		{
			var inputs = InputValues;
			Console.WriteLine (inputs [0].Length < inputs [1].Length ? inputs [1] : inputs [0]);
		}
	}
}
