using System;

namespace method_and_class
{
	class myclass
	{
		int a, b, c;

		public myclass()
		{
			this.a = 5425;
			Console.WriteLine ("myclass()");
		}

		public myclass(int b): this()
		{
			this.b = b;
			Console.WriteLine ("myclass({0})",b);
		}

		public myclass (int b, int c) : this (b)
		{
			this.c = c;
			Console.WriteLine ("myclass({0}. {1})", b, c);
		}

		public void printfield()
		{
			Console.WriteLine ("a:{0}, b:{1}, c:{2}", a, b, c);
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			myclass a = new myclass ();
			a.printfield ();
			Console.WriteLine ();

			myclass b = new myclass (1);
			b.printfield ();
			Console.WriteLine ();

			myclass c = new myclass (10,  20);
			c.printfield ();
			Console.WriteLine ();
		}
	}

}