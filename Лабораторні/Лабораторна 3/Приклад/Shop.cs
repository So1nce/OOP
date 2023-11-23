using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Приклад
{
    internal class Shop
    {
        public string Id { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int Price { get; private set; }
        public Shop(string id, string model, int year, int price) 
        {
            Id = id;
            Model = model;
            Year = year;
            Price = price;
        }
        public void PrintToConsole() 
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Автосалон:{Id}");
            Console.WriteLine($"Марка:{Model}");
            Console.WriteLine($"Рік:{Year}");
            Console.WriteLine($"Ціна:{Price}");
        }
    }
}
