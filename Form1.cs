namespace YP_1_2
{
    public partial class Form1 : Form
    {
        Shop shop = new Shop();//������� ��������� ��������
        Product product;//��������� ���������� ��� �������� �������� ��������

        public Form1() //����������� �����
        {
            InitializeComponent(); //������������� ����������� �����
        }

        //����� ��� ���������� ����� �������
        private void setTovarsButton_Click(object sender, EventArgs e)
        {
            //���������, ��������� �� ������� ���� � ���������� ������
            if (decimal.TryParse(priceTextBox.Text, out decimal bbd) && int.TryParse(countTextBox.Text, out int bbi))
            {
                //������� ����� ������� � �������� � �������� ���������, ����� � �����������
                shop.CreateProduct($"{nameTextBox.Text}", decimal.Parse(priceTextBox.Text), int.Parse(countTextBox.Text));
                //��������� ������ ���� ���������
                shop.WriteAllProducts(getProductsListBox);
            }
            else
            {
                //���� ������������ ���� - ������
                MessageBox.Show("Incorrect input", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //����� ��� ������� ������
        private void buyButton_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear(); //������� ������ ������� ����� ����� ��������
            product = shop.FindByName($"{searchTextBox.Text}");//���� ������� �� �����
            shop.Sell(product, listBox2);//������� ������

            shop.WriteAllProducts(getProductsListBox);//��������� ������ ���� ��������� �� ������
            shop.GetProfit(profitLabel); //��������� ���������� � �������

            shop.ClearBox();//������� ������� ����� �������
            listBox1.Items.Clear(); //������� ������ ������� � �������
            pricesLabel.Text = "0"; //���������� ����� ����� ��� �� 0
        }

        //����� ��� ���������� ������ � �������
        private void addToBoxButton_Click(object sender, EventArgs e)
        {
            product = shop.FindByName($"{searchTextBox.Text}"); //���� ������� �� �����
            shop.CreateProductBox(product, pricesLabel); //��������� ������� � ������� � ��������� ����� ����� �������

            shop.WriteAllProductsBox(listBox1);//��������� ������ ������� � ������� �� ������
            shop.WriteAllProducts(getProductsListBox);//��������� ������ ���� ��������� �� ������
        }

        //����� ��� ������� ������ �������
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //������� ������ ������� � �������
            pricesLabel.Text = "0"; //���������� ����� ����� �� 0
            shop.ClearBox(); //������� ���������� ������� � ��������
        }
    }
}
