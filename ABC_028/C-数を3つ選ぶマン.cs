// C - 数を3つ選ぶマン
// http://abc028.contest.atcoder.jp/tasks/abc028_c
// Accept: http://abc028.contest.atcoder.jp/submissions/496544

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
				// 入力値は 必ず 5 つの整数(<=100)が空白期切りで与えられるのが保証
				// ex) 1 20 3 5 8
				return Console.ReadLine().Split(' ');
			}
		}
		void Calc()
		{
			Out(InputValues
				.Select (i => int.Parse (i))
				.OrderByDescending(i => i)
				.ToArray()
			);
		}
		void Out(int[] inputs)
		{
			//1,2,3が最大、1,2,4が次点、3番目は 1,2,5 か 1,3,4 のどちらか
			Console.WriteLine(Math.Max(
				inputs[0] + inputs[1] + inputs[4], 
				inputs[0] + inputs[2] + inputs[3]
			));
		}
	}
}
