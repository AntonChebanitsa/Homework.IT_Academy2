using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Homework.IT_Academy2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathEl = "D:\\Homework.IT_Academy2\\ElectroCars.json";
            string pathFu = "D:\\Homework.IT_Academy2\\FuelCars.json";

            string content1 = File.ReadAllText(pathEl);
            string content2 = File.ReadAllText(pathFu);

            ElectroCar[] elCars = JsonConvert.DeserializeObject<ElectroCar[]>(content1);
            FuelCar[] fuCars = JsonConvert.DeserializeObject<FuelCar[]>(content2);

            Car[] cars = new Car[elCars.Length + fuCars.Length];

            for (int i = 0; i < elCars.Length; i++)
            {
                cars[i] = elCars[i];
            }

            for (int i = 0; i < fuCars.Length; i++)
            {
                cars[elCars.Length + i] = fuCars[i];
            }

            var station = new TaxiStation(cars);
            var a = station.SummaryCost();

            station.SortByCost();

            Console.WriteLine($"\nSummary cost is= {station.SummaryCost()}");

            station.FindBySpeed();
        }
    }
}