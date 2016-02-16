using System;

namespace method_and_class
{
	class employee
	{
		private string name;
		private string position;

		public void setname(string name)
		{
			this.name = name;
		}

		public string getname()
		{
			return name;
		}

		public void setposition(string position)
		{
			this.position = position;
		}

		public string getposition()
		{
			return position;
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			employee pooh = new employee ();
			pooh.setname ("pooh");
			pooh.setposition ("waiter");
			Console.WriteLine ("{0} {1}", pooh.getname (), pooh.getposition ());

		}
	}
}