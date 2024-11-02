using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_1_2
{
    class Shop
    {
        private Dictionary<Product, int> products;//словарь товаров магазина
        private Dictionary<Product, int> box;//словарь добавленного в коробку
        private List<string> buyHistory = new List<string>();//список истории покупок

        private decimal profit = 0;//вспомогательная переменная
        private decimal fullProfit = 0;//вспомогательная переменная
        public Shop()//конструктор
        {
            products = new Dictionary<Product, int>(); //инициализация словаря продуктов
            box = new Dictionary<Product, int>(); //инициализация словаря для коробки
        }

        public void WriteAllProducts(ListBox listBox) //вывод всего списка
        {
            listBox.Items.Clear();//чистим листбокс перед каждым новым заполнением
            foreach (var product in products)//идем по списку
            {
                listBox.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);//добавляем в листбокс из списка по ключу
                
            }
        }
        public void WriteAllProductsBox(ListBox listBox) //вывод всего списка
        {
            listBox.Items.Clear();//чистим листбокс перед каждым новым заполнением
            foreach (var product in box)//идем по коробке
            {
                listBox.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);//добавляем в листбокс из списка по ключу
            }
        }
        public void CreateProduct(string name, decimal price, int count)//добавляем товар в общий список
        {
            if (!products.Keys.Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))//linq-запрос для проверки есть ли уже созданный товар с таким именем
            {
                products.Add(new Product(name, price), count);//добавление товара в магазин
            }
            else
            {
                MessageBox.Show("Товар с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);//сообщение об ошибке
            }
        }
        
        public void CreateProductBox(Product product, Label label)//добавляем товар в коробку
        {
            if (product != null)//проверка, найден ли товар
            {
                if (products[product] <= 0)//"Нет в наличии!"
                {
                    MessageBox.Show("Нет в наличии!");
                }
                else
                {
                    fullProfit += product.Price;//счетчик товаров из коробки

                    if (box.ContainsKey(product))//если словать коробки содержит ключ типа Product, добавляем к количеству 1
                    {
                        box[product]++;
                        products[product]--;
                    }
                    else//иначе создаем новый элемент
                    {
                        box.Add(product, 1);
                        products[product]--;
                    }
                }
            }
            else
            {
                MessageBox.Show("Товар не найден", "Всё ещё Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label.Text = fullProfit.ToString();//вывод суммы цен товаров в вашей коробке на данный момент
        }

        public void Sell(Product product, ListBox listBox)//покупаем товар
        {
            decimal totalProfit = 0;//при новом вызове обновляет счетчик вспомогательной переменной для накопления общей прибыли от продажи

            foreach (var item in box)//проходимся по всем элементам словаря-коробки
            {
                product = item.Key; //получаем продукт из ключа словаря
                int quantity = item.Value; //получаем количество продукта из значения словаря

                totalProfit += product.Price * quantity;//увеличиваем общую прибыль, умножая цену на количество



                string record = $"{DateTime.Now}: {product.Name}, {quantity} шт.";
                buyHistory.Add(record);//добавляем запись о покупке в историю покупок


            }
            foreach (var sp in buyHistory)//проходим по всем записям в истории покупок
            {
                listBox.Items.Add(sp); //добавляем каждую запись в листбокс
            }
            profit += totalProfit; //обновляем общую прибыль магазина, не забывая прибавить прошлую прибыль
        }

        public Product FindByName(string name)//поиск по имени товара
        {
            foreach (var product in products.Keys)//проходим по всем ключам в словаре товаров магазина
            {
                if (product.Name == name)//если совпадает возвращаем найденное
                {
                    return product;
                }
            }
            return null; //продукт не найден, возвращаем null
        }

        public void GetProfit(Label label)//получение прибыли магазина
        {
            label.Text = profit.ToString();//устанавливаем общую прибыль в лейбел
        }

        public void ClearBox()//метод очищения списка коробки
        {
            fullProfit = 0; //сбрасываем прибыль до нуля, обновляем ее
            box.Clear();//очищаем словарь-коробку, удаляя все товары
        }
    }
}
