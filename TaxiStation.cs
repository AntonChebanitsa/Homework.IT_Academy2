using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Homework.IT_Academy2
{
    class TaxiStation
    {
        public Car[] Cars { get; set; }

        public TaxiStation(Car[] arrCars)
        {
            Cars = arrCars;
        }

        public void SortByCost()
        {
            Console.WriteLine("Cars before sorting");

            foreach (var car in Cars)
            {
                Console.WriteLine(car.Name + "=" + car.Cost);
            }

            var sortedByCost = from car in Cars
                orderby car.Speed
                select car;

            Console.WriteLine("\nCars after sorting");

            foreach (var car in sortedByCost)
            {
                Console.WriteLine(car.Name + "=" + car.Cost);
            }
        }

        public void FindBySpeed()
        {
            Console.WriteLine("\nEnter speed: ");
            var enteredSpeed = Convert.ToInt32(Console.ReadLine());
            bool isFounded = false;
            foreach (var car in Cars)
            {
                if (enteredSpeed == car.Speed)
                {
                    Console.WriteLine($"Founded car {car.Name}");
                    isFounded = true;
                    return;
                }
                else
                {
                    isFounded = false;
                }
            }
            if (isFounded == false)
                Console.WriteLine("Not found");
        }

        public int SummaryCost()
        {
            int sum = 0;
            foreach (var car in Cars)
                sum += car.Cost;
            return sum;
        }
    }
}