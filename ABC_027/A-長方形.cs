// ABC_027 A - 長方形
// http://abc027.contest.atcoder.jp/tasks/abc027_a
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
 
		void Calc()
		{
			var values = InputValue
				.Split(' ')
				.Select(i => int.Parse(i))
				.ToArray(); // { 4, 3, 4 }
 
			Console.WriteLine (
				values [0] == values [1] 
					? values [2] 
					: (values [0] == values[2] ? values[1] : values[0])
			);
		}
 
		string InputValue
		{
			get { 
				return Console.ReadLine();
			}
		}
	}
}