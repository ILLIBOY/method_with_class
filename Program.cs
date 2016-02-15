using System;

namespace method_and_class
{
	class myclass
	{
		public int myfield1;
		public int myfield2;

		public myclass deepcopy()
		{
			myclass newcopy = new myclass ();
			newcopy.myfield1 = this.myfield1;
			newcopy.myfield2 = this.myfield2;

			return newcopy;
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine ("shallow copy");
			{
				myclass source = new myclass ();
				source.myfield1 = 10;
				source.myfield2 = 20;
				myclass target = source;
				target.myfield2 = 30;
				Console.WriteLine ("{0} {1}", source.myfield1, source.myfield2);
				Console.WriteLine ("{0} {1}", target.myfield1, target.myfield2);
			}

			Console.WriteLine ("Deep Copy");

			{
				myclass source = new myclass ();
				source.myfield1 = 10;
				source.myfield2 = 20;
				myclass target = source.deepcopy ();
				target.myfield2 = 30;
				Console.WriteLine ("{0} {1}", source.myfield1, source.myfield2);
				Console.WriteLine ("{0} {1}", target.myfield1, target.myfield2);
			}
		}
	}
}