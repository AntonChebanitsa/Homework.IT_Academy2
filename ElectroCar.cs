using System;

namespace Homework.IT_Academy2
{
    public class ElectroCar : Car
    {
        public Battery BatteryProp { get; }

        public ElectroCar(string name, int speed, int cost, string typeFuel, Battery battery)
            : base(name, speed, cost, typeFuel)
        {
            BatteryProp = battery;
        }

        public override void Move()
        {
            Console.WriteLine("I'm moving absolutely silently");
        }

        public class Battery
        {
            public string Manufacturer { get; set; }
            public int ElectroCapacity { get; set; }
            public int ElectroConsumption { get; set; }

            public Battery(string manufacturer, int capacity, int consumption)
            {
                Manufacturer = manufacturer;
                ElectroCapacity = capacity;
                ElectroConsumption = consumption;
            }
        }
    }
}