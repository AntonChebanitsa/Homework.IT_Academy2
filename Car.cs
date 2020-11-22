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

        protected Car(string name, int speed, int cost, string typeFuel)
        {
            Name = name;
            Speed = speed;
            Cost = cost;
            TypeFuel = typeFuel;
        }

        public abstract void Move();
    }
}
