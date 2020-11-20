using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
            Car value;
            for (int i = 0; i < Cars.Length - 1; i++)
            {
                for (int j = i + 1; j < Cars.Length; j++)
                {
                    if (Cars[i].Cost > Cars[j].Cost)
                    {
                        value = Cars[i];
                        Cars[i] = Cars[j];
                        Cars[j] = value;
                    }
                }
            }
        }
        public void FindBySpeed(Car[] c)
        {
            Console.WriteLine("Enter speed: ");
            var enteredSpeed = Convert.ToInt32(Console.ReadLine());
            foreach (var car in Cars)
                Console.WriteLine(enteredSpeed == car.Speed ? $"Founded car {car.Name}" : "Not found");
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

/*
Таксопарк.
Определить иерархию легковых автомобилей. 
Создать таксопарк.
Посчитать стоимость автопарка.
Провести сортировку автомобилей парка по расходу топлива. 
Найти автомобиль в компании, соответствующий заданному диапазону параметров скорости.
*/