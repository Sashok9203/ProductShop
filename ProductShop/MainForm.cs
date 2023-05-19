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

        List<Product> productList;

        public MainForm()
        {
            productList = new();
            InitializeComponent();
            sourceUpdate();
        }

        private void addButtonClk(object sender, EventArgs e)
        {
            ProductForm pf = new();
            if (pf.ShowDialog() == DialogResult.OK)
            {
                productList.Add(pf.Product);
                sourceUpdate();
            }
        }

        private void editButtonClk(object sender, EventArgs e)
        {
            if (productsList.SelectedIndex >= 0)
            {
                ProductForm pf = new(productList[productsList.SelectedIndex], Actions.Edit);
                if(pf.ShowDialog() == DialogResult.OK)
                    sourceUpdate();
            }
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
                ProductForm pf = new(productList[productsList.SelectedIndex], Actions.Show);
                pf.ShowDialog();
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