using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLTestRange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection connection;

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //Connection to MySQL server
                connection = new MySqlConnection("SERVER=localhost; DATABASE=customers; USERNAME=root; PASSWORD=12345678;");
                connection.Open();

                //If server connection successful display this... 
                if (connection.State == ConnectionState.Open)
                {
                    //... message
                    label1.Text = "Connected";
                    label1.ForeColor = Color.Green;
                }

                //Else display this...
                else
                {
                    //...message
                    label1.Text = "Connection Failed";
                    label1.ForeColor = Color.Red;
                }

            }

            //For displaying errors
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //The connection status message display label
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //The close connection button
        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                label1.Text = "Connection Failed";
                label1.ForeColor = Color.Red;
            }
        }

        //The open connection button
        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                label1.Text = "Connected";
                label1.ForeColor = Color.Green;
            }
        }
    }
}