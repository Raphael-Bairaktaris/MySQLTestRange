namespace MySQLTestRange
{
    partial class DataNavigation
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
            ProductIdLabel = new Label();
            CategoryIdLabel = new Label();
            SupplierIdLabel = new Label();
            ProductNameLabel = new Label();
            PriceLabel = new Label();
            UnitLabel = new Label();
            ProductIdTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            SupplierIdTextBox = new TextBox();
            CategoryIdTextBox = new TextBox();
            UnitTextBox = new TextBox();
            PriceTextBox = new TextBox();
            FirstButton = new Button();
            NextButton = new Button();
            LastButton = new Button();
            PreviousButton = new Button();
            SuspendLayout();
            // 
            // ProductIdLabel
            // 
            ProductIdLabel.AutoSize = true;
            ProductIdLabel.Location = new Point(127, 115);
            ProductIdLabel.Name = "ProductIdLabel";
            ProductIdLabel.Size = new Size(62, 15);
            ProductIdLabel.TabIndex = 0;
            ProductIdLabel.Text = "Product Id";
            // 
            // CategoryIdLabel
            // 
            CategoryIdLabel.AutoSize = true;
            CategoryIdLabel.Location = new Point(127, 219);
            CategoryIdLabel.Name = "CategoryIdLabel";
            CategoryIdLabel.Size = new Size(68, 15);
            CategoryIdLabel.TabIndex = 1;
            CategoryIdLabel.Text = "Category Id";
            // 
            // SupplierIdLabel
            // 
            SupplierIdLabel.AutoSize = true;
            SupplierIdLabel.Location = new Point(127, 184);
            SupplierIdLabel.Name = "SupplierIdLabel";
            SupplierIdLabel.Size = new Size(63, 15);
            SupplierIdLabel.TabIndex = 2;
            SupplierIdLabel.Text = "Supplier Id";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(127, 151);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(84, 15);
            ProductNameLabel.TabIndex = 3;
            ProductNameLabel.Text = "Product Name";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(127, 290);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(33, 15);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Price";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Location = new Point(127, 254);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new Size(29, 15);
            UnitLabel.TabIndex = 5;
            UnitLabel.Text = "Unit";
            // 
            // ProductIdTextBox
            // 
            ProductIdTextBox.Location = new Point(268, 107);
            ProductIdTextBox.Name = "ProductIdTextBox";
            ProductIdTextBox.Size = new Size(189, 23);
            ProductIdTextBox.TabIndex = 6;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(268, 143);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(189, 23);
            ProductNameTextBox.TabIndex = 7;
            // 
            // SupplierIdTextBox
            // 
            SupplierIdTextBox.Location = new Point(268, 176);
            SupplierIdTextBox.Name = "SupplierIdTextBox";
            SupplierIdTextBox.Size = new Size(189, 23);
            SupplierIdTextBox.TabIndex = 8;
            // 
            // CategoryIdTextBox
            // 
            CategoryIdTextBox.Location = new Point(268, 211);
            CategoryIdTextBox.Name = "CategoryIdTextBox";
            CategoryIdTextBox.Size = new Size(189, 23);
            CategoryIdTextBox.TabIndex = 9;
            // 
            // UnitTextBox
            // 
            UnitTextBox.Location = new Point(268, 246);
            UnitTextBox.Name = "UnitTextBox";
            UnitTextBox.Size = new Size(189, 23);
            UnitTextBox.TabIndex = 10;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(268, 282);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(189, 23);
            PriceTextBox.TabIndex = 11;
            // 
            // FirstButton
            // 
            FirstButton.Location = new Point(497, 281);
            FirstButton.Name = "FirstButton";
            FirstButton.Size = new Size(75, 23);
            FirstButton.TabIndex = 12;
            FirstButton.Text = "First";
            FirstButton.UseVisualStyleBackColor = true;
            FirstButton.Click += FirstButton_Click;
            // 
            // NextButton
            // 
            NextButton.Location = new Point(578, 282);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(75, 23);
            NextButton.TabIndex = 13;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = true;
            NextButton.Click += NextButton_Click;
            // 
            // LastButton
            // 
            LastButton.Location = new Point(740, 281);
            LastButton.Name = "LastButton";
            LastButton.Size = new Size(75, 23);
            LastButton.TabIndex = 14;
            LastButton.Text = "Last";
            LastButton.UseVisualStyleBackColor = true;
            LastButton.Click += LastButton_Click;
            // 
            // PreviousButton
            // 
            PreviousButton.Location = new Point(659, 282);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(75, 23);
            PreviousButton.TabIndex = 15;
            PreviousButton.Text = "Previous";
            PreviousButton.UseVisualStyleBackColor = true;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // DataNavigation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 613);
            Controls.Add(PreviousButton);
            Controls.Add(LastButton);
            Controls.Add(NextButton);
            Controls.Add(FirstButton);
            Controls.Add(PriceTextBox);
            Controls.Add(UnitTextBox);
            Controls.Add(CategoryIdTextBox);
            Controls.Add(SupplierIdTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductIdTextBox);
            Controls.Add(UnitLabel);
            Controls.Add(PriceLabel);
            Controls.Add(ProductNameLabel);
            Controls.Add(SupplierIdLabel);
            Controls.Add(CategoryIdLabel);
            Controls.Add(ProductIdLabel);
            Name = "DataNavigation";
            Text = "DataNavigation";
            Load += DataNagivation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductIdLabel;
        private Label CategoryIdLabel;
        private Label SupplierIdLabel;
        private Label ProductNameLabel;
        private Label PriceLabel;
        private Label UnitLabel;
        private TextBox ProductIdTextBox;
        private TextBox ProductNameTextBox;
        private TextBox SupplierIdTextBox;
        private TextBox CategoryIdTextBox;
        private TextBox UnitTextBox;
        private TextBox PriceTextBox;
        private Button FirstButton;
        private Button NextButton;
        private Button LastButton;
        private Button PreviousButton;
    }
}