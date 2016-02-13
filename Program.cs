using System;

namespace method_and_class
{
	class MainClass
	{

		static double Square(double arg)
		{
			return arg * arg;
		}

		public static void Main (string[] args)
		{
			Console.Write ("수를 입력하세요 : ");
			string input = Console.ReadLine ();
			double arg = Convert.ToDouble (input);

			Console.WriteLine ("result : {0}", Square (arg));
		}
	}
}