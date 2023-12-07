using DOAN._Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DOAN._controllManager
{
    public partial class CheckIn : UserControl
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Tran Dong Phuong\\OneDrive\\Desktop\\DoAn_OOP\\DOAN\\_data\\hotel_db.mdf\";Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adapter;
        string command;
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }



        private void btConfirmCIN_Click(object sender, EventArgs e)
        {
            if(dataGridView.Rows.Count > 1)
            {
                conn.Open();
                command = "UPDATE Room_Info SET CheckIn='" + DateTime.Today + "', RoomStatus='" + "OCCUPIED" + "', ChekOut='" + "OCCUPIED" + "' WHERE FirstName = '" + fNameBox.Text + "' AND LastName = '" + lNameBox.Text + "' AND PhoneNumber = '" + pNumberBox.Text + "'";
                cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                search();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại thông tin", "Status");
                return;
            }
        }

        private void search()
        {
            conn.Open();
            adapter = new SqlDataAdapter();
            command = String.Format("SELECT * FROM Room_Info WHERE PhoneNumber='" + "{0}" + "' AND FirstName='" + "{1}" + "' AND LastName='" + "{2}" + "' AND RoomStatus = '"+"EMPTY"+"'", pNumberBox.Text, fNameBox.Text, lNameBox.Text);
            adapter.SelectCommand = new SqlCommand(command, conn);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView.DataSource = bSource;
            conn.Close();
        }

        private void fRoomInfoBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(fNameBox.Text) || string.IsNullOrWhiteSpace(lNameBox.Text) || string.IsNullOrWhiteSpace(pNumberBox.Text))
            {
                MessageBox.Show("Không tìm thấy thông tin phòng", "Status");
                return;
            }
            search();
            if(dataGridView.Rows.Count == 1)
            {
                MessageBox.Show("Vui lòng nhập lại thông tin", "Status");
                return;
            }
        }
    }
}
