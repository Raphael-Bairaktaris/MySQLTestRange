using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLTestRange
{
    public partial class InsertDataToMySQL : Form
    {
        //Connects to the databse
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=12345678;");

        MySqlCommand command = new MySqlCommand();

        MySqlDataReader mdr;

        /// <summary>
        /// Default constructor
        /// </summary>
        public InsertDataToMySQL()
        {
            InitializeComponent();
        }

        private void InsertDataToMySQL_Load(object sender, EventArgs e)
        {

        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// A class for opening connection and executing queries
        /// </summary>
        public void ExecuteQuery(String query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query executed");
                }

                else
                {
                    MessageBox.Show("Query not executed");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                CloseConnection();
            }
        }

        /// <summary>
        /// This is the insert on click button
        /// </summary>
        private void InsertButton_Click(object sender, EventArgs e)
        {
            // Inserts data into database
            ExecuteQuery($"INSERT INTO `customers`.`customerinformation`(`CustomerName`, `Address`, `City`, `PostalCode`, `Country`) VALUES ('{CustomerNameTextBox.Text}','{AddressTextBox.Text}','{CityTextBox.Text}','{PostalCodeTextBox.Text}','{CountryTextBox.Text}')");
        }

        /// <summary>
        /// This is the delete on click button
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Deletes data from the database
            ExecuteQuery($"DELETE FROM `customers`.`customerinformation` WHERE `CustomerID` ='{IdTextBox.Text}'");
        }

        /// <summary>
        /// This is the update on click button
        /// </summary>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Updates the database
            ExecuteQuery($"UPDATE `customers`.`customerinformation` SET `CustomerName`='{IdTextBox.Text}','{CustomerNameTextBox.Text}','{AddressTextBox.Text}','{CityTextBox.Text}','{PostalCodeTextBox.Text}','{CountryTextBox.Text}'");
        }

        /// <summary>
        /// This is the search button
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Opens connection
            OpenConnection();

            // Executes the select query
            command = new MySqlCommand($"SELECT * FROM `customers`.`customerinformation` WHERE `CustomerID` ='{IdTextBox.Text}'", connection);

            // Reader is executed
            mdr = command.ExecuteReader();

            // If reader records a value below ...
            if(mdr.Read())
            {
                // ...Returns customer's name
                CustomerNameTextBox.Text = mdr.GetString("CustomerName");

                // ...Returns the address
                AddressTextBox.Text = mdr.GetString("Address");

                // ...Returns city
                CityTextBox.Text = mdr.GetString("City");

                // ...Returns the postal code
                PostalCodeTextBox.Text = mdr.GetString("PostalCode");

                // ...Returns the country
                CountryTextBox.Text = mdr.GetString("Country");
            }

            // If reader does not record any values then...
            else
            {
                // ...Return empty values
                CustomerNameTextBox.Text = "";
                AddressTextBox.Text = "";
                CityTextBox.Text = "";
                PostalCodeTextBox.Text = "";
                CountryTextBox.Text = "";

                // Message shown
                MessageBox.Show("Empty");
            }

            mdr.Close();
            
            connection.Close();
        }
    }
}
