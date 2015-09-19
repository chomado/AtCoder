// A - 複数形
// http://abc029.contest.atcoder.jp/tasks/abc029_a 
using System;
using System.IO;
 
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
			Console.WriteLine (InputValue + "s");
		}
 
		string InputValue
		{
			get { 
				return Console.ReadLine();
			}
		}
 
	}
}