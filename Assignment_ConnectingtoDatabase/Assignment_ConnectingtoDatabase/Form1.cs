using System.Data;
using System.Data.SqlClient;

namespace Assignment_ConnectingtoDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AppsDev_Database;";

            SqlConnection con = new(connectionString);
            con.Open();

            string query = "SELECT * FROM [User]";

            SqlDataAdapter da = new(query, connectionString);

            DataSet ds = new();
            da.Fill(ds, "User");
            dataGridView1.DataSource = ds.Tables["User"].DefaultView;

            con.Close();
        }
    }
}
