using System;

namespace method_and_class
{
	class cat
	{
		public string name;
		public string Color;

		public void meow()
		{
			Console.WriteLine ("name : {0}, color : {1}", name, Color);
		}
	}
		
	class MainAPP
	{
		static void Main(string[] args)
		{
			cat Kitty = new cat();
			Kitty.Color = "white";
			Kitty.name = "kitty";
			Kitty.meow();

			cat nero = new cat();
			nero.Color = "black";
			nero.name = "nero";
			nero.meow();
		}
	}
}