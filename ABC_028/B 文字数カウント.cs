// 文字数カウント
// http://abc028.contest.atcoder.jp/tasks/abc028_b

/* 
 入力例:
 DECADE
 * 
 出力例:
 1 0 1 2 2 0
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
			var counts = new Dictionary<char, int>(){
				{'A', 0}, {'B', 0}, {'C', 0}, {'D', 0}, {'E', 0}, {'F', 0},
			};
			var inputs = InputValues;
			foreach (var c in inputs)
			{
				counts[c]++;
			}
			Output(counts);
		}

		char[] InputValues
		{
			get { 
				// 入力値は 必ず A, B, C, D, E, F の 6 種類の文字から構成されている文字列であるのが保証
				// ex) DECADE
				return Console.ReadLine().ToCharArray();
			}
		}

		void Output(Dictionary<char, int> counts)
		{
			foreach (var value in counts)
			{
				if (value.Key == 'F')
				{
					Console.Write(value.Value + "\n");
				}
				else
				{
					Console.Write(value.Value + " ");
				}
			}
		}
	}
}
