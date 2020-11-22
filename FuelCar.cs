using System;

namespace Homework.IT_Academy2
{
    public class FuelCar : Car
    {
        public double Consumption { get; set; }
        public FuelTank FuelTankProp { get; }

        public FuelCar(string name, int speed, int cost, double consumption, string typeFuel, FuelTank fuelTank)
            : base(name, speed, cost, typeFuel)
        {
            Consumption = consumption;
            FuelTankProp = fuelTank;
            TypeFuel = typeFuel;
        }

        public override void Move()
        {
            Console.WriteLine("I travel long distances without refueling");
        }
        public class FuelTank
        {
            public int Capacity { get; set; }
        }
    }
}