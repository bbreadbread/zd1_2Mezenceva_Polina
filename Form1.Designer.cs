namespace YP_1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            setTovarsButton = new Button();
            priceTextBox = new TextBox();
            nameTextBox = new TextBox();
            priceLabel = new Label();
            nameLabel = new Label();
            getProductsListBox = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            countTextBox = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            pricesLabel = new Label();
            label6 = new Label();
            button1 = new Button();
            label4 = new Label();
            listBox1 = new ListBox();
            addToBoxButton = new Button();
            profitLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            searchTextBox = new TextBox();
            buyButton = new Button();
            tabPage3 = new TabPage();
            listBox2 = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // setTovarsButton
            // 
            setTovarsButton.BackColor = Color.DarkSeaGreen;
            setTovarsButton.Font = new Font("Segoe UI", 13F);
            setTovarsButton.Location = new Point(48, 265);
            setTovarsButton.Name = "setTovarsButton";
            setTovarsButton.Size = new Size(659, 41);
            setTovarsButton.TabIndex = 0;
            setTovarsButton.Text = "Add product";
            setTovarsButton.UseVisualStyleBackColor = false;
            setTovarsButton.Click += setTovarsButton_Click;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.Honeydew;
            priceTextBox.Font = new Font("Segoe UI", 13F);
            priceTextBox.Location = new Point(48, 196);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(303, 36);
            priceTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.Honeydew;
            nameTextBox.Font = new Font("Segoe UI", 13F);
            nameTextBox.Location = new Point(48, 124);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(659, 36);
            nameTextBox.TabIndex = 2;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 13F);
            priceLabel.Location = new Point(48, 163);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(65, 30);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Price:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 13F);
            nameLabel.Location = new Point(48, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(76, 30);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // getProductsListBox
            // 
            getProductsListBox.BackColor = Color.Honeydew;
            getProductsListBox.Font = new Font("Segoe UI", 13F);
            getProductsListBox.FormattingEnabled = true;
            getProductsListBox.ItemHeight = 30;
            getProductsListBox.Location = new Point(23, 23);
            getProductsListBox.Name = "getProductsListBox";
            getProductsListBox.Size = new Size(618, 184);
            getProductsListBox.TabIndex = 5;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(758, 501);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(countTextBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(setTovarsButton);
            tabPage1.Controls.Add(nameLabel);
            tabPage1.Controls.Add(priceTextBox);
            tabPage1.Controls.Add(priceLabel);
            tabPage1.Controls.Add(nameTextBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(750, 468);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // countTextBox
            // 
            countTextBox.BackColor = Color.Honeydew;
            countTextBox.Font = new Font("Segoe UI", 13F);
            countTextBox.Location = new Point(404, 196);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(303, 36);
            countTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(404, 163);
            label1.Name = "label1";
            label1.Size = new Size(76, 30);
            label1.TabIndex = 6;
            label1.Text = "Count:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pricesLabel);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(addToBoxButton);
            tabPage2.Controls.Add(profitLabel);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(searchTextBox);
            tabPage2.Controls.Add(buyButton);
            tabPage2.Controls.Add(getProductsListBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(750, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Shop";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pricesLabel
            // 
            pricesLabel.AutoSize = true;
            pricesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            pricesLabel.Location = new Point(647, 377);
            pricesLabel.Name = "pricesLabel";
            pricesLabel.Size = new Size(18, 20);
            pricesLabel.TabIndex = 16;
            pricesLabel.Text = "0";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(647, 319);
            label6.Name = "label6";
            label6.Size = new Size(95, 58);
            label6.TabIndex = 15;
            label6.Text = "Всего к оплате:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(446, 231);
            button1.Name = "button1";
            button1.Size = new Size(129, 69);
            button1.TabIndex = 14;
            button1.Text = "Clear box";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(23, 296);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 13;
            label4.Text = "Your box:";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Honeydew;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(23, 319);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(618, 124);
            listBox1.TabIndex = 12;
            // 
            // addToBoxButton
            // 
            addToBoxButton.BackColor = Color.DarkSeaGreen;
            addToBoxButton.Font = new Font("Segoe UI", 10F);
            addToBoxButton.Location = new Point(294, 231);
            addToBoxButton.Name = "addToBoxButton";
            addToBoxButton.Size = new Size(129, 69);
            addToBoxButton.TabIndex = 11;
            addToBoxButton.Text = "Add to box";
            addToBoxButton.UseVisualStyleBackColor = false;
            addToBoxButton.Click += addToBoxButton_Click;
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            profitLabel.Location = new Point(647, 81);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(18, 20);
            profitLabel.TabIndex = 10;
            profitLabel.Text = "0";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(647, 23);
            label3.Name = "label3";
            label3.Size = new Size(95, 58);
            label3.TabIndex = 9;
            label3.Text = "Прибыль магазина:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 223);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 8;
            label2.Text = "Search by name: ";
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.Honeydew;
            searchTextBox.Font = new Font("Segoe UI", 12F);
            searchTextBox.Location = new Point(23, 246);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(247, 34);
            searchTextBox.TabIndex = 7;
            // 
            // buyButton
            // 
            buyButton.BackColor = Color.DarkSeaGreen;
            buyButton.Font = new Font("Segoe UI", 10F);
            buyButton.Location = new Point(598, 231);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(129, 69);
            buyButton.TabIndex = 6;
            buyButton.Text = "Buy product";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += buyButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listBox2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(750, 468);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "History";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Honeydew;
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(47, 41);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(656, 384);
            listBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(758, 501);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Products";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button setTovarsButton;
        private TextBox priceTextBox;
        private TextBox nameTextBox;
        private Label priceLabel;
        private Label nameLabel;
        private ListBox getProductsListBox;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox countTextBox;
        private Label label1;
        private Button buyButton;
        private Label label2;
        private TextBox searchTextBox;
        private Label profitLabel;
        private Label label3;
        private Button addToBoxButton;
        private Label label4;
        private ListBox listBox1;
        private TabPage tabPage3;
        private ListBox listBox2;
        private Button button1;
        private Label pricesLabel;
        private Label label6;
    }
}
