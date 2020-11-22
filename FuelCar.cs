using System;

namespace Homework.IT_Academy2
{
    public class FuelTank
    {
        public int Capacity { get; set; }
    }
    public class FuelCar : Car
    {
        public double Consumption { get; set; }
        public FuelTank FuelTank { get; }

        public FuelCar(string name, int speed, int cost, double consumption, string typeFuel, FuelTank fuelTank)
            : base(name, speed, cost, typeFuel)
        {
            Consumption = consumption;
            FuelTank = fuelTank;
            TypeFuel = typeFuel;
        }

        public override void Move()
        {
            Console.WriteLine("I travel long distances without refueling");
        }
    }
}