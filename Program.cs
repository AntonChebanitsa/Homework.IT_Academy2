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

            var ts = new TaxiStation(cars);
            var a = ts.SummaryCost();

            Console.WriteLine("Cars before sorting");

            foreach (var car in ts.Cars)
            {
                Console.WriteLine(car.Name + "=" + car.Cost);
            }
            ts.SortByCost();
            Console.WriteLine("Cars after sorting");
            foreach (var car in ts.Cars)
            {
                Console.WriteLine(car.Name + "=" + car.Cost);
            }

        }
    }
}

/*
Таксопарк.
Определить иерархию легковых автомобилей. 
Создать таксопарк.
Посчитать стоимость автопарка.
Провести сортировку автомобилей парка по расходу топлива. 
Найти автомобиль в компании, соответствующий заданному диапазону параметров скорости.
var car = new Car("Ford", 1000, 7.6, 1000);
*/