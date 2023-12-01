using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Khach : Form
    {
        string connectstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\OOP_22162001\\Project\\DOAN\\DOAN\\room.mdf;Integrated Security=True";
        SqlConnection conn;
        public Khach()
        {
            InitializeComponent();
        }

        private void Khach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomDataSet1.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.roomDataSet1.Room);
            // TODO: This line of code loads data into the 'roomDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.roomDataSet.Room);
            conn = new SqlConnection(connectstring);
            conn.Open();
            string cmd = "SELECT * FROM Room";
            SqlCommand sqlCommand = new SqlCommand(cmd, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            datagribview.DataSource = dataSet;
            conn.Close();
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            conn.Open();
            string cmd = "SELECT Id FROM Room";
            SqlCommand sqlCommand = new SqlCommand(cmd, conn);
            sqlCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = guna2TextBox1.Text;
            SqlDataReader read = sqlCommand.ExecuteReader();
            if (read.HasRows)
            {
                MessageBox.Show("hello");
            }
            conn.Close();
            sqlCommand.Dispose();
            read.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
