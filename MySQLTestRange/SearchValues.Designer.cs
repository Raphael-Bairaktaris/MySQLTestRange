namespace MySQLTestRange
{
    partial class SearchValues
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
            IDTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            CityTextBox = new TextBox();
            Search_bt = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CountryTextBox = new TextBox();
            PostalCodeTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(161, 46);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(291, 23);
            IDTextBox.TabIndex = 0;
            IDTextBox.TextChanged += ID_Text_box_TextChanged;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(161, 104);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(291, 23);
            CustomerNameTextBox.TabIndex = 1;
            CustomerNameTextBox.TextChanged += First_Name_text_box_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(161, 165);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(291, 23);
            AddressTextBox.TabIndex = 2;
            AddressTextBox.TextChanged += Last_Name_Text_box_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(159, 227);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(291, 23);
            CityTextBox.TabIndex = 3;
            // 
            // Search_bt
            // 
            Search_bt.BackColor = SystemColors.AppWorkspace;
            Search_bt.Location = new Point(483, 341);
            Search_bt.Name = "Search_bt";
            Search_bt.Size = new Size(66, 23);
            Search_bt.TabIndex = 4;
            Search_bt.Text = "Search";
            Search_bt.UseVisualStyleBackColor = false;
            Search_bt.Click += Search_bt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 54);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 112);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 6;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 173);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 235);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "City";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(161, 291);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(291, 23);
            CountryTextBox.TabIndex = 9;
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(159, 341);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(291, 23);
            PostalCodeTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 299);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 349);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 12;
            label6.Text = "Postal Code";
            // 
            // SearchValues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 642);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(PostalCodeTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Search_bt);
            Controls.Add(CityTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(IDTextBox);
            Name = "SearchValues";
            Text = "SearchValues";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IDTextBox;
        private TextBox CustomerNameTextBox;
        private TextBox AddressTextBox;
        private TextBox CityTextBox;
        private Button Search_bt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CountryTextBox;
        private TextBox PostalCodeTextBox;
        private Label label5;
        private Label label6;
    }
}