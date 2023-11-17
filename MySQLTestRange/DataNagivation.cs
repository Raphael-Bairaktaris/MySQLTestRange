using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLTestRange
{
    public partial class DataNavigation : Form
    {
        // Setting up the connection
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=12345678;");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        // Setting index to position 0
        int pos = 0;

        /// <summary>
        /// Default constructor
        /// </summary>
        public DataNavigation()
        {
            InitializeComponent();
        }

        // This is the data navigation load
        private void DataNagivation_Load(object sender, EventArgs e)
        {
            // Connecting with mysql server and table
            adapter = new MySqlDataAdapter("SELECT * FROM `customers`.`products`", connection);
            adapter.Fill(table);
            showData(pos);
        }

        // This is for showing data in the texts box
        public void showData(int index)
        {
            ProductIdTextBox.Text = table.Rows[index][0].ToString();
            ProductNameTextBox.Text = table.Rows[index][1].ToString();
            SupplierIdTextBox.Text = table.Rows[index][2].ToString();
            CategoryIdTextBox.Text = table.Rows[index][3].ToString();
            UnitTextBox.Text = table.Rows[index][4].ToString();
            PriceTextBox.Text = table.Rows[index][5].ToString();
        }

        // This is the first button and it sets the pointer to position zero
        private void FirstButton_Click(object sender, EventArgs e)
        {
            // Sets the pointer to the first value in the table
            pos = 0;
            showData(pos);
        }

        // This is the next button and it increases the pointer position by one
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Icreaces the pointer's position by one
            pos++;

            // If pointer's position can be increased...
            if (pos <= table.Rows.Count)
            {
                // ... then show data
                showData(pos);
            }

            else
            {
                // ... else show this message
                MessageBox.Show("End");
                pos = table.Rows.Count - 1;
            }
        }

        // This is the previous button and it reduces the pointer position by one
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            // Reduces the pointer's position by one
            pos--;

            // If pointers position can be reduced...
            if (pos >= 0)
            {
                // ... then show data
                showData(pos);
            }

            // ... else show this message
            else
            {
                MessageBox.Show("End");
            }
        }

        // This is the last button and it makes the pointer hop to the last value in the table
        private void LastButton_Click(object sender, EventArgs e)
        {
            pos = table.Rows.Count - 1;
            showData(pos);
        }
    }
}
