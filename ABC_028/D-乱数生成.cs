// C - 数を3つ選ぶマン
// http://abc028.contest.atcoder.jp/tasks/abc028_c

/*
 * 問題文
 異なる整数が 5 個与えられます。

 この中から 3 つ選んでその和で表すことの出来る整数のうち、3 番目に大きいものを出力してください。

 * 入力例:
 1 2 3 5 8

 * 出力例:
 14

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

		string[] InputValues
		{
			get { 
				// 入力値は 必ず 2 つの整数 が 空白区切りで与えられるのが保証
				// ex) 3 2
				return Console.ReadLine().Split(' ');
			}
		}
		void Calc()
		{
			var inputs = InputValues
				.Select (i => int.Parse (i))
				.ToArray()
			;
			int n = inputs [0];
			int k = inputs [1];
			var total = Math.Pow (n, 3);

			Out (Combination (n, k), total);
		}

		double Combination(int n, int k)
		{
			double bigger = n - k; // 個
			double smaller = k - 1; // 個
			return
				// 3値とも k
				1
				// 3つのうち 2値が k
				+ 3 * (1 * 1 * (n - 1)) 
				// 3つのうち 1値が k
				+ bigger * smaller * (3 * 2 * 1);
		}

		void Out(double combination, double total)
		{
			Console.WriteLine(
				combination / total
			);
		}
	}
}
