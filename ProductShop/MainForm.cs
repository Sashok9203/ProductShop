using Microsoft.VisualBasic.Logging;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.Arm;
using System;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public enum Actions
        {
            Edit,
            Show,
            Add
        }

        readonly List<Product> productList;

        readonly ProductForm productForm; 

        public MainForm()
        {
            productForm = new();
            productList = new();
            InitializeComponent();
            sourceUpdate();
        }

        private void addButtonClk(object sender, EventArgs e)
        {
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                productList.Add(productForm.Product);
                sourceUpdate();
            }
        }

        private void editButtonClk(object sender, EventArgs e)
        {
            if (productsList.SelectedIndex >= 0)
              if(productForm.ShowDialog(productList[productsList.SelectedIndex], Actions.Edit) == DialogResult.OK)
                    sourceUpdate();
        }

        private void delButtonClk(object sender, EventArgs e)
        {
            if (productsList.SelectedIndex >= 0)
            {
                productList.RemoveAt(productsList.SelectedIndex);
                sourceUpdate();
            }
        }

        private void showButtonClk(object sender, EventArgs e)
        {
            if (productsList.SelectedIndex >= 0)
            {
                productForm.ShowDialog(productList[productsList.SelectedIndex], Actions.Show);
                productsList.SelectedIndex = -1;
            }
        }

        private void exitButtonClk(object sender, EventArgs e) => Close();

        private void sourceUpdate()
        {
            productsList.DataSource = productList.ToArray();
            productsList.SelectedIndex = -1;
        }
    }
}