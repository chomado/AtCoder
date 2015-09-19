// B - 高橋くんの集計
// http://abc015.contest.atcoder.jp/tasks/abc015_2

/* 
 入力例:
4
0 1 3 8
 * 
 出力例:
4
 */

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
			var inputs = InputValues
				.Select (i => int.Parse (i))
				.Where (i => i != 0)
				.ToList ();
			double ave = (double)inputs.Sum () / (double)inputs.Count;
			Console.WriteLine (Math.Ceiling(ave));
		}

		string[] InputValues
		{
			get { 
				// 1行目は捨てる
				Console.ReadLine();
				// 入力値は 必ず スペース区切りの 整数であるのが保証
				// ex) 0 1 3 8
				return Console.ReadLine().Split(' ');
			}
		}

	}
}