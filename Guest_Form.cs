using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Guest_Form : Form
    {
        string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\OOP_22162001\\Project\\DOAN\\DOAN\\_data\\room_db.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public Guest_Form()
        {
            InitializeComponent();
        }

        private void Guest_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'room_dbDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.room_dbDataSet.Room);

        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionstring);
            string command = String.Format("SELECT Id FROM Room WHERE Id = '" + "{0}" + "'", bookBox.Text);

        }
        private void reload()
        {
            SqlConnection sql = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter();
            string command = "SELECT * FROM Test";
            adapter.SelectCommand = new SqlCommand(command, sql);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView.DataSource = bSource;
            sql.Close();
            
        }
    }
}
