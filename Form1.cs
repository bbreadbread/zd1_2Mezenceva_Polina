namespace YP_1_2
{
    public partial class Form1 : Form
    {
        Shop shop = new Shop();//создаем экземпл€р магазина
        Product product;//объ€вл€ем переменную дл€ хранени€ текущего продукта

        public Form1() //конструктор формы
        {
            InitializeComponent(); //инициализаци€ компонентов формы
        }

        //метод дл€ добавлени€ новых товаров
        private void setTovarsButton_Click(object sender, EventArgs e)
        {
            //провер€ем, корректно ли введены цена и количество товара
            if (decimal.TryParse(priceTextBox.Text, out decimal bbd) && int.TryParse(countTextBox.Text, out int bbi))
            {
                //создаем новый продукт в магазине с заданным названием, ценой и количеством
                shop.CreateProduct($"{nameTextBox.Text}", decimal.Parse(priceTextBox.Text), int.Parse(countTextBox.Text));
                //обновл€ем список всех продуктов
                shop.WriteAllProducts(getProductsListBox);
            }
            else
            {
                //если некорректный ввод - ошибка
                MessageBox.Show("Incorrect input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //метод дл€ покупки товара
        private void buyButton_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); //очищаем список покупок перед новой покупкой
            product = shop.FindByName($"{searchTextBox.Text}");//ищем продукт по имени
            shop.Sell(product, listBox2);//покупка товара

            shop.WriteAllProducts(getProductsListBox);//обновл€ем список всех продуктов на выводе
            shop.GetProfit(profitLabel); //обновл€ем информацию о прибыли

            shop.ClearBox();//очищаем коробку после продажи
            listBox1.Items.Clear(); //очищаем список товаров в коробке
            pricesLabel.Text = "0"; //сбрасываем текст метки цен до 0
        }

        //метод дл€ добавлени€ товара в коробку
        private void addToBoxButton_Click(object sender, EventArgs e)
        {
            product = shop.FindByName($"{searchTextBox.Text}"); //ищем продукт по имени
            shop.CreateProductBox(product, pricesLabel); //добавл€ем продукт в коробку и обновл€ем вывод суммы покупки

            shop.WriteAllProductsBox(listBox1);//обновл€ем список товаров в коробке на выводе
            shop.WriteAllProducts(getProductsListBox);//обновл€ем список всех продуктов на выводе
        }

        //метод дл€ очистки списка коробки
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //очищаем список товаров в коробке
            pricesLabel.Text = "0"; //сбрасываем текст лейбл до 0
            shop.ClearBox(); //очищаем содержимое коробки в магазине
        }
    }
}
