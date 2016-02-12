using System;

namespace method_and_class
{
	class MainClass
	{

		static void profile(string name, string phone)
		{
			Console.WriteLine ("name:{0}, phone:{1}", name, phone);
		}

		public static void Main (string[] args)
		{
			profile (name: "chulwon_jung", phone: "010-4063-5296");
		}
	}
}
