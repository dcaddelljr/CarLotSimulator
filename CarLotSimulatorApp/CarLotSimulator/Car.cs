using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(string year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            //EngineNoise = engineNoise;

            //Console.WriteLine($"The {Year} {Make} {Model} has a engine that is {EngineNoise}. The {Model} {IsDriveable}.");
            Console.WriteLine($"The car engine goes {engineNoise}");
        }
        public void MakeHonkNoise(string honkNoise)
        {
            //HonkNoise = honkNoise;
            //Console.WriteLine($"The {Year} {Make} {Model} has a horn that is {HonkNoise}. The {Model} {IsDriveable}.");
            Console.WriteLine($"The car horn goes {honkNoise}");
        }
    }
}

