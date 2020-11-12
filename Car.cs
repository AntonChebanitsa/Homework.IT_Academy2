using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace Homework.IT_Academy2
{
    public abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Cost { get; set; }

        protected Car(string name, int speed, int cost)
        {
            Name = name;
            Speed = speed;
            Cost = cost;
        }
    }
    public class Battery
    {
        public string Manufacturer { get; set; }
        public int ElectroCapacity { get; set; }
    }
    public class ElectroCar : Car
    {
        public Battery Battery { get; }
        public ElectroCar(string name, int speed, int cost, Battery battery)
            : base(name, speed, cost)
        {
            Battery = battery;
        }

    }
    public class FuelTank
    {
        public string TypeFuel { get; set; }
        public int Capacity { get; set; }
    }
    public class FuelCar : Car
    {
        public double Consumption { get; set; }
        public FuelTank FuelTank { get; set; }
        public FuelCar(string name, int speed, int cost, double consumption, FuelTank fuelTank)
            : base(name, speed, cost)
        {
            Consumption = consumption;
            FuelTank = fuelTank;
        }
    }
}
