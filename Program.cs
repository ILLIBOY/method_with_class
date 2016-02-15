using System;

namespace method_and_class
{
	class cat
	{
		public string name;
		public string color;

		public cat()
		{
			name = "";
			color = "";
		}

		public cat(string _name, string _color)
		{
			name=_name;
			color=_color;
		}

		~cat()
		{
			Console.WriteLine ("{0} : goodbye", name);
		}
			

		public void meow()
		{
			Console.WriteLine ("{0} : 야옹", name);
		}
	}
		
	class MainAPP
	{
		static void Main(string[] args)
		{
			cat Kitty = new cat ("kitty", "white");
			Kitty.meow ();
			cat bongbong = new cat ("bongbong", "brown");
			bongbong.meow ();
		}
	}
}