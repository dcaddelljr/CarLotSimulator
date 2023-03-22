using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{ }

		//Have this number only increment when in our program we create a new Car.
		//From there create 3 cars in the Main() and then each time you create a car, do a Console.WriteLine() printing the current number of cars in the car lot.
		public static int numberOfCars = 1;


		public List<Car> ParkingLot { get; set; } = new List<Car>();

		
	}
        

		
	
}

