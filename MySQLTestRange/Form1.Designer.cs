namespace MySQLTestRange
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
            label1 = new Label();
            Close_Connection_bt = new Button();
            Open_Connection_bt = new Button();
            SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(313, 94);
            label1.Name = "CustomerNameLabel";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // Close_Connection_bt
            // 
            Close_Connection_bt.Location = new Point(186, 345);
            Close_Connection_bt.Name = "Close_Connection_bt";
            Close_Connection_bt.Size = new Size(116, 23);
            Close_Connection_bt.TabIndex = 1;
            Close_Connection_bt.Text = "Close Connection";
            Close_Connection_bt.UseVisualStyleBackColor = true;
            Close_Connection_bt.Click += button1_Click;
            // 
            // Open_Connection_bt
            // 
            Open_Connection_bt.Location = new Point(486, 345);
            Open_Connection_bt.Name = "Open_Connection_bt";
            Open_Connection_bt.Size = new Size(116, 23);
            Open_Connection_bt.TabIndex = 2;
            Open_Connection_bt.Text = "Open Connection";
            Open_Connection_bt.UseVisualStyleBackColor = true;
            Open_Connection_bt.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Open_Connection_bt);
            Controls.Add(Close_Connection_bt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Close_Connection_bt;
        private Button Open_Connection_bt;
    }
}