namespace MySQLTestRange
{
    partial class InsertDataToMySQL
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
            CustomerNameLabel = new Label();
            AddressLabel = new Label();
            CityLabel = new Label();
            PostalCodeLabel = new Label();
            CountryLabel = new Label();
            CustomerNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            CityTextBox = new TextBox();
            PostalCodeTextBox = new TextBox();
            CountryTextBox = new TextBox();
            InsertButton = new Button();
            DeleteButton = new Button();
            UpdateButton = new Button();
            CustomerId = new Label();
            IdTextBox = new TextBox();
            SearchButton = new Button();
            SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(84, 96);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(94, 15);
            CustomerNameLabel.TabIndex = 0;
            CustomerNameLabel.Text = "Customer Name";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(84, 145);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(49, 15);
            AddressLabel.TabIndex = 1;
            AddressLabel.Text = "Address";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(84, 191);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 2;
            CityLabel.Text = "City";
            // 
            // PostalCodeLabel
            // 
            PostalCodeLabel.AutoSize = true;
            PostalCodeLabel.Location = new Point(84, 235);
            PostalCodeLabel.Name = "PostalCodeLabel";
            PostalCodeLabel.Size = new Size(70, 15);
            PostalCodeLabel.TabIndex = 3;
            PostalCodeLabel.Text = "Postal Code";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(84, 279);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(50, 15);
            CountryLabel.TabIndex = 4;
            CountryLabel.Text = "Country";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(260, 88);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(282, 23);
            CustomerNameTextBox.TabIndex = 5;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(260, 137);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(282, 23);
            AddressTextBox.TabIndex = 6;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(260, 183);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(282, 23);
            CityTextBox.TabIndex = 7;
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(260, 227);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(282, 23);
            PostalCodeTextBox.TabIndex = 8;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(260, 271);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(282, 23);
            CountryTextBox.TabIndex = 9;
            // 
            // InsertButton
            // 
            InsertButton.Location = new Point(577, 270);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(75, 23);
            InsertButton.TabIndex = 10;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(658, 271);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 11;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(739, 271);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // CustomerId
            // 
            CustomerId.AutoSize = true;
            CustomerId.Location = new Point(84, 45);
            CustomerId.Name = "CustomerId";
            CustomerId.Size = new Size(72, 15);
            CustomerId.TabIndex = 13;
            CustomerId.Text = "Customer id";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(260, 37);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(282, 23);
            IdTextBox.TabIndex = 14;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(820, 270);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 15;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // InsertDataToMySQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 588);
            Controls.Add(SearchButton);
            Controls.Add(IdTextBox);
            Controls.Add(CustomerId);
            Controls.Add(UpdateButton);
            Controls.Add(DeleteButton);
            Controls.Add(InsertButton);
            Controls.Add(CountryTextBox);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(CountryLabel);
            Controls.Add(PostalCodeLabel);
            Controls.Add(CityLabel);
            Controls.Add(AddressLabel);
            Controls.Add(CustomerNameLabel);
            Name = "InsertDataToMySQL";
            Text = "InsertDataToMySQL";
            Load += InsertDataToMySQL_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CustomerNameLabel;
        private Label AddressLabel;
        private Label CityLabel;
        private Label PostalCodeLabel;
        private Label CountryLabel;
        private TextBox CustomerNameTextBox;
        private TextBox AddressTextBox;
        private TextBox CityTextBox;
        private TextBox PostalCodeTextBox;
        private TextBox CountryTextBox;
        private Button InsertButton;
        private Button DeleteButton;
        private Button UpdateButton;
        private Label CustomerId;
        private TextBox IdTextBox;
        private Button SearchButton;
    }
}