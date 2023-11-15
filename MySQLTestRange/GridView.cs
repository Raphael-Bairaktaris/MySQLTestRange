using MySql.Data.MySqlClient;
using System.Data;

namespace MySQLTestRange
{
    public partial class GridView : Form
    {
        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            //This is the server connection string
            MySqlConnection connection = new MySqlConnection("DATASOURCE = localhost; PORT = 3306; username = root; password = 12345678;");

            //This is for selecting the data from a specific database
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM customers.customerinformation", connection);

            //Connection is open
            connection.Open();

            try
            {
                //Creating a new data set
                DataSet ds = new DataSet();

                //Showing users from table
                adapter.Fill(ds, "users");

                //
                dataGridView1.DataSource = ds.Tables["users"];

                //Closing connection
                connection.Close();
            }

            catch (Exception ex)
            {
                //This is for showing errors
                MessageBox.Show(ex.Message);
            }
        }

        //This is the data grid view box
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
