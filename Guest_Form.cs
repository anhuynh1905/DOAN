using DOAN._Class;
using DOAN._controllManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DOAN
{
    public partial class Guest_Form : Form
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Tran Dong Phuong\\OneDrive\\Desktop\\DOAN\\_data\\hotel_db.mdf\";Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataAdapter adapter;
        
        string command;
        string insert;
        SqlDataReader reader;
        public Guest_Form()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guest_Form_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapter = new SqlDataAdapter();
            command = "SELECT * FROM Room_Info WHERE RoomStatus = '"+"Empty"+"'";
            adapter.SelectCommand = new SqlCommand(command, conn);

            DataTable table = new DataTable();
            adapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            datagridview.DataSource = bSource;
            conn.Close();
            feedBack1.Visible = false;
        }

        private void Book_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(CheckIn.Value < now)
            {
                Statuslable.Text = "Please re-enter check in date or check out date";
                return;
            }
            if(fNameBox.Text == "" || lNameBox.Text == "" || pNumberBox.Text == "" || RoomBox.Text == "" || pNumberBox.Text.Length < 10)
            {
                Statuslable.Text = "Please enter more information";
                return;
            }
            List<Guest> guests = new List<Guest>();
            conn.Open();
            command = String.Format("SELECT RoomStatus FROM Room_Info WHERE RoomID = '" + "{0}" + "'", Int32.Parse(RoomBox.Text));
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if (Convert.ToString(reader["RoomStatus"]).Trim() == "FALSE")
                {
                    Statuslable.Text = "Room is already been occupied, please choose another room";
                    reader.Close();
                    conn.Close();
                    cmd.Dispose();
                    return;
                }
            }
            reader.Close();
            guests.Add(new Guest(fNameBox.Text, lNameBox.Text, pNumberBox.Text));
            insert = String.Format("UPDATE Room_Info SET FirstName='" + "{0}" + "', LastName='" + "{1}" + "', PhoneNumber='" + "{2}" + "', CheckIn='" + "{3}" + "', CheckOut='" + "{4}" + "', RoomStatus='" + "Occupied" + "' WHERE RoomID='" + "{5}" + "'",
                        fNameBox.Text, lNameBox.Text, pNumberBox.Text, CheckIn.Value, CheckOut.Value, Int32.Parse(RoomBox.Text));
            cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();

            Statuslable.Text = "Success Booking !";
            conn.Close();
            cmd.Dispose();
            Guest_Form_Load(sender, e);
        }

        private void btfeed_Click(object sender, EventArgs e)
        {
            feedBack1.Visible = true;
            feedBack1.BringToFront();
        }
    }
}
