using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
	class Program
	{

		interface ICar
		{
			void Drive();
			void AddGas(int amount);
		}

		class CompactCar : ICar
		{
			int GasAmount;
			public void Drive()
			{
				Console.WriteLine("I'm driving");
			}
			public void AddGas(int amount)
			{
				GasAmount += amount;
				Console.WriteLine($"I'm adding gas. Now have {GasAmount}");
			}

		}

		class HighPerfCar : ICar
		{
			int GasAmount;
			public void Drive()
			{
				Console.WriteLine("I'm driving really fast");
			}

			public void AddGas(int amount)
			{
				GasAmount += amount;
				Console.WriteLine($"I'm adding high-octane fuel. Now have {GasAmount}");
			}
		}

		static void Main(string[] args)
		{
			CompactCar car1 = new CompactCar();
			car1.Drive();
			car1.AddGas(5);

			HighPerfCar car2 = new HighPerfCar();
			car2.Drive();
			car2.AddGas(10);

			List<ICar> mylist = new List<ICar>();
			mylist.Add(car1);
			mylist.Add(car2);

			// ICar another = new CompactCar();  Advanced topic to play with on your own
		}
	}
}

