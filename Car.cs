using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace Homework.IT_Academy2
{
    public abstract class Car: IMovable
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Cost { get; set; }
        public string TypeFuel { get; set; }

        public Car(string name, int speed, int cost, string typeFuel)
        {
            Name = name;
            Speed = speed;
            Cost = cost;
            TypeFuel = typeFuel;
        }
        public abstract void Move();
    }
    public class Battery
    {
        public string Manufacturer { get; set; }
        public int ElectroCapacity { get; set; }
        public int ElectroConsumption { get; set; }
    }
    public class ElectroCar : Car
    {
        public Battery Battery { get; }
        public ElectroCar(string name, int speed, int cost, string typeFuel, Battery battery)
            : base(name, speed, cost, typeFuel)
        {
            Battery = battery;
        }
        public override void  Move()
        {
            Console.WriteLine($"I'm moving with {TypeFuel}");
        }
    }
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
            Console.WriteLine($"I'm moving on {TypeFuel} fuel");
        }
    }
}
