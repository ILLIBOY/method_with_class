using System;

namespace method_and_class
{
	class waterheater
	{
		protected int temperature;

		public void settemperature (int temperature)
		{
			if (temperature < -5 || temperature > 42)
				throw new Exception ("Out of temperature range");
			this.temperature = temperature;
		}

		internal void TurnOnWater()
		{
			Console.WriteLine ("Turn on wanter : {0}", temperature);
		}
	}

	class MainApp
	{
		static void Main(string[] args)
		{
			try
			{
				waterheater heater = new waterheater();
				heater.settemperature(20);
				heater.TurnOnWater();

				heater.settemperature(-2);
				heater.TurnOnWater();

				heater.settemperature(50);
				heater.TurnOnWater();
			}
			catch (Exception e) 
			{
				Console.WriteLine (e.Message);
			}
		}
	}
}