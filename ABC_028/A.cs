using System;
using System.IO;

namespace test
{
	class Chomado
	{
		public Chomado() {}
		public static int Main()
		{
			new Chomado ().Calc ();
			return 0;
		}

		void Calc()
		{
			Console.WriteLine (OutputValue(input: InputValue));
		}

		int InputValue
		{
			get { 
				// 入力値は 0 以上 100 以下の整数が保証
				return int.Parse(Console.ReadLine ()); 
			}
		}

		string OutputValue(int input)
		{
			if (input < 60)
			{
				return "Bad";
			} 
			else if (input < 90)
			{
				return "Good";
			} 
			else if (input < 100)
			{
				return "Great";
			}
			return "Perfect";
		}
	}
}
