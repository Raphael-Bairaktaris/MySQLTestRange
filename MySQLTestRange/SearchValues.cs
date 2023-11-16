using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLTestRange
{
    public partial class SearchValues : Form
    {
        //Connects to the database
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=12345678;");

        //Initializes a new instance of command
        MySqlCommand command = new MySqlCommand();

        //Vairiable
        MySqlDataReader mdr;

        public SearchValues()
        {
            InitializeComponent();
        }

        //This is the search button
        private void Search_bt_Click(object sender, EventArgs e)
        {
            //Opens the connection
            connection.Open();

            //Select from a specific table of the database
            string selectQuery = "SELECT * FROM `customers`.`customerinformation` WHERE CustomerID=" + int.Parse(IDTextBox.Text);

            //
            command = new MySqlCommand(selectQuery, connection);

            //Executes reader
            mdr = command.ExecuteReader();

            //If reader records one of below
            if (mdr.Read())
            {
                //Get customer name
                CustomerNameTextBox.Text = mdr.GetString("CustomerName");

                //Get customer address
                AddressTextBox.Text = mdr.GetString("Address");

                //Get customer city
                CityTextBox.Text = mdr.GetString("City");

                //Get customer postal code
                PostalCodeTextBox.Text = mdr.GetString("PostalCode");

                //Get customer country
                CountryTextBox.Text = mdr.GetString("Country");
            }

            //Else if the values below are empty or do not exist show ...
            else
            {
                
                IDTextBox.Text = "";
                CustomerNameTextBox.Text = "";
                AddressTextBox.Text = "";
                CityTextBox.Text = "";
                PostalCodeTextBox.Text = "";
                CountryTextBox.Text = "";

                //...this message
                MessageBox.Show("No data for this ID");
            }

            //Closes connection 
            connection.Close();
        }
    }
}
