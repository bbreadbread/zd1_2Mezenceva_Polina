using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1_2
{
    class Product
    {
        public decimal Price { get; set; }//свойство цены
        public string Name { get; set; }//свойство имени

        public Product(string Name, decimal Price) // конструктор присваивания
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string GetInfo()//вывод информации
        {
            return $"Наименование: {Name}; Цена: {Price} руб.";
        }
    }
}