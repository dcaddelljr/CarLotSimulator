using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
              //TODO
                var dwightsCarLot = new CarLot();
                //Dot Notation Syntax
                var car1 = new Car();
                car1.Year = "2023";
                car1.Make = "Ford";
                car1.Model = "Expedition";
                car1.EngineNoise = "vroom";
                car1.HonkNoise = "honk";
                car1.IsDriveable = true;

                //car1.MakeEngineNoise("engineNoise");
                dwightsCarLot.ParkingLot.Add(car1);

                //Object Initializer Syntax
                var car2 = new Car()
                {
                    Year = "2012",
                    Make = "Ford",
                    Model = "F150",
                    EngineNoise = "loud",
                    HonkNoise = "hoooonk",
                    IsDriveable = true
                };

                dwightsCarLot.ParkingLot.Add(car2);



                //Custom Constructor
                var car3 = new Car("1988", "Chevy", "Suburban", "VROOM", "Honk", false);

                dwightsCarLot.ParkingLot.Add(car3);
                //Create a seperate class file called Car
                //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
                //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
                //The methods should take one string parameter: the respective noise property


                //Now that the Car class is created we can instanciate 3 new cars
                //Set the properties for each of the cars
                //Call each of the methods for each car

                //*************BONUS*************//

                // Set the properties utilizing the 3 different ways we learned about, one way for each car



                //*************BONUS X 2*************//

                //Create a CarLot class
                //It should have at least one property: a List of cars
                //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                //At the end iterate through the list printing each of car's Year, Make, and Model to the console

                foreach (var car in dwightsCarLot.ParkingLot)
                {
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model:{car.Model}");
                    Console.WriteLine($"EngineNoise: {car.EngineNoise}");
                    Console.WriteLine($"HonkNoise: {car.HonkNoise}");
                    Console.WriteLine($"IsDriveable: {car.IsDriveable}");
                    Console.WriteLine();
                }
            
        }
    }
}
