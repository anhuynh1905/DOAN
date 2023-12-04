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
            conn.Open();
            DateTime dateTime = DateTime.Today;
            string command = String.Format("UPDATE Room SET Status='"+"Book"+"', FirstName='"+"{1}"+"', LastName='"+"{2}"+"', Phone='"+"{3}"+"', Date='"+"{4}"+"' WHERE Id='"+"{0}"+"'", 
                bookBox.Text,fNameBox.Text,lNameBox.Text,pNumberBox.Text,dateTime);

            string check = String.Format("SELECT * FROM Room WHERE Id='" + "{0}" + "'", bookBox.Text);
            cmd = new SqlCommand(check, conn);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[1].ToString() == "Occupied            ")
                {
                    MessageBox.Show("Room already been Occupied!!", "Caution");
                    rdr.Close();
                    cmd.Dispose();
                    conn.Close();
                    return;
                }
            }
            rdr.Close();

            cmd = new SqlCommand(command, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand=new SqlCommand(command, conn);
            adapter.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show("Booking Success", "Caution");
            cmd.Dispose();
            conn.Close();
            reload();
            
        }
        private void reload()
        {
            SqlConnection sql = new SqlConnection(connectionstring);
            SqlDataAdapter adapter = new SqlDataAdapter();
            string command = "SELECT * FROM Room";
            adapter.SelectCommand = new SqlCommand(command, sql);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView.DataSource = bSource;
            sql.Close();
            
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
