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
		List<string> list = new List<string>();
 
		public static int Main()
		{
			new Chomado ().Calc ();
			return 0;
		}
		void Calc()
		{
			var MAX_LENGTH = int.Parse (Console.ReadLine ());
			Dive ("", 0, MAX_LENGTH);
			list.Distinct ().ToList ().ForEach (Console.WriteLine);
		}
		// 再帰関数
		void Dive(string prefix, int level, int MAX_LENGTH)
		{
			level++;
			foreach (var c in VALID_CHARS)
			{
				if (level <= MAX_LENGTH)
					Dive (prefix + c, level, MAX_LENGTH);
				else
					list.Add (prefix);
			}
		}
	}
}