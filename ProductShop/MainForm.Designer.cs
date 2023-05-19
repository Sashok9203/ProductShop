namespace WinFormsApp1
{
    partial class MainForm
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
            addButton = new Button();
            delButton = new Button();
            showButton = new Button();
            products = new Label();
            editButton = new Button();
            exitButton = new Button();
            productsList = new ListBox();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(34, 67);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 25);
            addButton.TabIndex = 0;
            addButton.Text = "Add Product";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButtonClk;
            // 
            // delButton
            // 
            delButton.Location = new Point(34, 129);
            delButton.Name = "delButton";
            delButton.Size = new Size(100, 25);
            delButton.TabIndex = 1;
            delButton.Text = "Delete Product";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButtonClk;
            // 
            // showButton
            // 
            showButton.Location = new Point(34, 160);
            showButton.Name = "showButton";
            showButton.Size = new Size(100, 25);
            showButton.TabIndex = 2;
            showButton.Text = "Show Product";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButtonClk;
            // 
            // products
            // 
            products.AutoSize = true;
            products.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            products.Location = new Point(153, 18);
            products.MaximumSize = new Size(158, 32);
            products.MinimumSize = new Size(158, 32);
            products.Name = "products";
            products.Size = new Size(158, 32);
            products.TabIndex = 3;
            products.Text = "Product Shop";
            // 
            // editButton
            // 
            editButton.Location = new Point(34, 98);
            editButton.Name = "editButton";
            editButton.Size = new Size(100, 25);
            editButton.TabIndex = 5;
            editButton.Text = "Edit Product";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButtonClk;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(34, 191);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(100, 25);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButtonClk;
            // 
            // productsList
            // 
            productsList.FormattingEnabled = true;
            productsList.ItemHeight = 15;
            productsList.Location = new Point(184, 87);
            productsList.Name = "productsList";
            productsList.Size = new Size(252, 124);
            productsList.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(162, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 152);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 251);
            Controls.Add(productsList);
            Controls.Add(exitButton);
            Controls.Add(editButton);
            Controls.Add(products);
            Controls.Add(showButton);
            Controls.Add(delButton);
            Controls.Add(addButton);
            Controls.Add(groupBox1);
            MaximumSize = new Size(500, 290);
            MinimumSize = new Size(500, 290);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button delButton;
        private Button showButton;
        private Label products;
        private Button editButton;
        private Button exitButton;
        private ListBox productsList;
        private GroupBox groupBox1;
    }
}