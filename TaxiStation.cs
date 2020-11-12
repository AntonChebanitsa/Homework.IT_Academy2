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

        public Car[] Cars { get;}

        Car SortByConsumption(double consumption)
        {
            return null;
        }
        void FindBySpeed() { }
        float SummaryCost()
        {
            return 0;
        }
        public TaxiStation(string filePath)
        {
            string content = File.ReadAllText(filePath);
            Cars = (Car[])JsonConvert.DeserializeObject(content);
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