﻿using System;

namespace Homework.IT_Academy2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\USER\\source\\repos\\Homework.IT_Academy2";
            var station = new TaxiStation(path);
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