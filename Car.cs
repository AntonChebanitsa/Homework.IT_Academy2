using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.IT_Academy2
{
    class Car
    {
        string Name { get; set; }
        int Speed { get; set; }
        double Consumption { get; set; }
        int Cost { get; set; }

        public Car(string name, int speed, double consumption, int cost)
        {
            Name = name;
            Speed = speed;
            Consumption = consumption;
            Cost = cost;
        }
    }
}
