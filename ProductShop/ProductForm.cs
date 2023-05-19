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


        public ProductForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Product product, MainForm.Actions action)
        {
            this.action = action;
            Product = product;
            formChange();
            return base.ShowDialog();
        }

        public new DialogResult ShowDialog()
        {
            action = MainForm.Actions.Add;
            formChange();
            return base.ShowDialog();
        }

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

        private bool isFieldsEmpty()
        {
            bool result = string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(countryComboBox.Text);
            if (result) MessageBox.Show("Fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return result;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case MainForm.Actions.Add:
                    if (isFieldsEmpty()) return;
                    Product = new Product(nameTextBox.Text, countryComboBox.Text, (double)priceNumericUpDown.Value,
                            (double)discountNumericUpDown.Value, (int)countNumericUpDown.Value);
                    break;

                case MainForm.Actions.Edit:
                    if (isFieldsEmpty()) return;
                    Product.Name = nameTextBox.Text;
                    Product.Country = countryComboBox.Text;
                    Product.Price = (double)priceNumericUpDown.Value;
                    Product.Discount = (double)discountNumericUpDown.Value;
                    Product.Count = (int)countNumericUpDown.Value;
                    break;

                case MainForm.Actions.Show:
                    cancel.Show();
                    actionButton.Location = new(45, 200);
                    nameTextBox.Enabled = true;
                    countryComboBox.Enabled = true;
                    priceNumericUpDown.Enabled = true;
                    discountNumericUpDown.Enabled = true;
                    countNumericUpDown.Enabled = true;
                    break;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
