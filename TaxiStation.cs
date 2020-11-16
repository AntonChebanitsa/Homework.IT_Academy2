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
        public Car[] Cars { get; }
        double sum = 0;
        Car SortByConsumption(double consumption)
        {
            return null;
        }
        public void FindBySpeed(Car[] car)
        {
            Console.WriteLine("Enter speed: ");
            int enteredSpeed = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Cars.Length; i++)
                if (enteredSpeed = )
                    Console.WriteLine("");
            Console.WriteLine();
        }
        public double SummaryCost(int cost)
        {
            for (int i = 0; i < Cars.Length; i++)
                sum += cost;
            return sum;
        }
        public TaxiStation(string filePath)
        {
            string content = File.ReadAllText(filePath);
            Cars = JsonConvert.DeserializeObject<Car[]>(content);
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