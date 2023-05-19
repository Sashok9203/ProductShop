using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ProductForm : Form
    {
        public Product Product { get; private set; }

        private MainForm.Actions action;

        public ProductForm(Product product, MainForm.Actions action)
        {
            InitializeComponent();
            this.action = action;
            Product = product;
            formChange();
        }

        public ProductForm()
        {
            InitializeComponent();
            action = MainForm.Actions.Add;
            formChange();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            switch (action)
            {
                case MainForm.Actions.Add:
                    Product = new Product(nameTextBox.Text, countryComboBox.Text, (double)priceNumericUpDown.Value,
                            (double)discountNumericUpDown.Value, (int)countNumericUpDown.Value);
                    break;

                case MainForm.Actions.Edit:
                    Product.Name = nameTextBox.Text;
                    Product.Country = countryComboBox.Text;
                    Product.Price = (double)priceNumericUpDown.Value;
                    Product.Discount = (double)discountNumericUpDown.Value;
                    Product.Count = (int)countNumericUpDown.Value;
                    break;
            }
            Close();
        }

        private void cancelClick(object sender, EventArgs e) => Close();

        private void formChange()
        {
            switch (action)
            {
                case MainForm.Actions.Add:
                    actionButton.Text = "Create";
                    Text = "Add Product";
                    return;

                case MainForm.Actions.Edit:
                    actionButton.Text = "Save";
                    Text = "Edit Product";
                    break;

                case MainForm.Actions.Show:
                    actionButton.Text = "Exit";
                    cancel.Hide();
                    actionButton.Location = new((Size.Width - actionButton.Size.Width) / 2, actionButton.Location.Y);
                    Text = "Product info";
                    nameTextBox.Enabled = false;
                    countryComboBox.Enabled = false;
                    priceNumericUpDown.Enabled = false;
                    discountNumericUpDown.Enabled = false;
                    countNumericUpDown.Enabled = false;
                    break;
            }
            nameTextBox.Text = Product.Name;
            countryComboBox.Text = Product.Country;
            priceNumericUpDown.Value = (decimal)Product.Price;
            discountNumericUpDown.Value = (decimal)Product.Discount;
            countNumericUpDown.Value = Product.Count;
        }
    }
}
