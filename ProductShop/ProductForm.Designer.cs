namespace WinFormsApp1
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            countryComboBox = new ComboBox();
            label2 = new Label();
            priceNumericUpDown = new NumericUpDown();
            countNumericUpDown = new NumericUpDown();
            label3 = new Label();
            discountNumericUpDown = new NumericUpDown();
            label4 = new Label();
            actionButton = new Button();
            cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(32, 30);
            label.Name = "label";
            label.Size = new Size(39, 15);
            label.TabIndex = 0;
            label.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(115, 26);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Country";
            // 
            // countryComboBox
            // 
            countryComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            countryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Items.AddRange(new object[] { "Argentina", "Australia", "Austria", "Belgium", "Brazil", "Canada", "China", "Czech Republic", "Denmark", "Egypt", "Finland", "France", "Germany", "Greece", "India", "Indonesia", "Ireland", "Israel", "Italy", "Japan", "Mexico", "Netherlands", "New Zealand", "Norway", "Poland", "Portugal", "Saudi Arabia", "Singapore", "South Africa", "South Korea", "Spain", "Sweden", "Switzerland", "Thailand", "Turkey", "Ukraine", "United Kingdom", "United States", "Vietnam" });
            countryComboBox.Location = new Point(115, 57);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(150, 23);
            countryComboBox.Sorted = true;
            countryComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 90);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Price";
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Location = new Point(115, 88);
            priceNumericUpDown.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(80, 23);
            priceNumericUpDown.TabIndex = 5;
            // 
            // countNumericUpDown
            // 
            countNumericUpDown.Location = new Point(115, 117);
            countNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            countNumericUpDown.Name = "countNumericUpDown";
            countNumericUpDown.Size = new Size(80, 23);
            countNumericUpDown.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 119);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Count";
            // 
            // discountNumericUpDown
            // 
            discountNumericUpDown.DecimalPlaces = 2;
            discountNumericUpDown.Location = new Point(115, 146);
            discountNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            discountNumericUpDown.Name = "discountNumericUpDown";
            discountNumericUpDown.Size = new Size(80, 23);
            discountNumericUpDown.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 148);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Discount";
            // 
            // actionButton
            // 
            actionButton.DialogResult = DialogResult.OK;
            actionButton.Location = new Point(43, 201);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(105, 23);
            actionButton.TabIndex = 10;
            actionButton.Text = "button1";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += ButtonClick;
            // 
            // cancel
            // 
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new Point(180, 201);
            cancel.Name = "cancel";
            cancel.Size = new Size(105, 23);
            cancel.TabIndex = 11;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancelClick;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 251);
            Controls.Add(cancel);
            Controls.Add(actionButton);
            Controls.Add(discountNumericUpDown);
            Controls.Add(label4);
            Controls.Add(countNumericUpDown);
            Controls.Add(label3);
            Controls.Add(priceNumericUpDown);
            Controls.Add(label2);
            Controls.Add(countryComboBox);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(label);
            MaximumSize = new Size(350, 290);
            MinimumSize = new Size(350, 290);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)countNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)discountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox nameTextBox;
        private Label label1;
        private ComboBox countryComboBox;
        private Label label2;
        private NumericUpDown priceNumericUpDown;
        private NumericUpDown countNumericUpDown;
        private Label label3;
        private NumericUpDown discountNumericUpDown;
        private Label label4;
        private Button actionButton;
        private Button cancel;
    }
}