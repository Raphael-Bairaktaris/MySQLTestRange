using MySql.Data.MySqlClient;

namespace MySQLTestRange
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            try
            {
                //This is the string for connecting to the database
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=12345678;");

                //This string selects the database's products
                string selectQuery = "SELECT * FROM `customers`.`products`";

                //Opens a database connection
                connection.Open();

                //Initializes a new instance of command
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                //Creates a reader object
                MySqlDataReader reader = command.ExecuteReader();

                //Takes the reader to the next record. If there are no other records returns false.
                while (reader.Read())
                {
                    //Adds an item to the combo box
                    comboBox1.Items.Add(reader.GetString("ProductName"));
                }
            }

            catch (Exception ex)
            {
                //Message box for showing errors
                MessageBox.Show(ex.Message);
            }
        }
    }
}
