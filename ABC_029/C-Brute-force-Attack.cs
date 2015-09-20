// C - Brute-force Attack
// 問題: http://abc029.contest.atcoder.jp/tasks/abc029_c

/* 組み合わせの列挙の問題.

入力例:
2

出力例:
aa
ab
ac
ba
bb
bc
ca
cb
cc

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
		char[] VALID_CHARS = new char [3] { 'a', 'b', 'c' };

		public static int Main()
		{
			new Chomado ().Calc ();
			return 0;
		}

		void Calc()
		{
			var MAX_LENGTH = int.Parse (Console.ReadLine ());
			Dive ("", MAX_LENGTH);
		}

		// 再帰関数
		void Dive(string prefix, int level)
		{
			if (level == 0)
			{
				Console.WriteLine (prefix);
			}
			else
			{
				foreach (var c in VALID_CHARS)
				{
					Dive (prefix + c, level - 1);
				}
			}
		}
	}
} 