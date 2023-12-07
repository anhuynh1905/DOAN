using DOAN._Class;
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
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DOAN._controllManager
{
    public partial class CheckOut : UserControl
    {
        function fn = new function();
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Tran Dong Phuong\\OneDrive\\Desktop\\DoAn_OOP\\DOAN\\_data\\hotel_db.mdf\";Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        SqlDataReader rdr;
        SqlDataAdapter adapter;
        string command;
        public CheckOut()
        {
            InitializeComponent();
        }


        private void CheckOut_Load(object sender, EventArgs e)
        {

        }
        private void search()
        {
            conn.Open();
            adapter = new SqlDataAdapter();
            command = String.Format("SELECT * FROM Room_Info WHERE RoomID = '"+"{0}"+"'",rIDBox.Text);
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
            if (string.IsNullOrWhiteSpace(rIDBox.Text))
            {
                MessageBox.Show("Không tìm thấy thông tin phòng", "Status");
                return;
            }
            search();
            if (dataGridView.Rows.Count == 1)
            {
                MessageBox.Show("Vui lòng nhập lại thông tin", "Status");
                return;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 1)
            {
                string data = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Tran Dong Phuong\\OneDrive\\Desktop\\DoAn_OOP\\DOAN\\_data\\hotel_db.mdf\";Integrated Security=True";
                string query = "insert into CheckOut (RoomID, FirstName, LastName, PhoneNumber, DateCO, RoomPrice) select RoomID, FirstName, LastName, PhoneNumber, CheckOut, RoomPrice from Room_Info where RoomID = '" + rIDBox.Text + "'";
                SqlConnection db = new SqlConnection(data);
                SqlCommand cmd = new SqlCommand(query, db);
                SqlDataReader sdr;
                try
                {
                    db.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                command = "UPDATE Room_Info SET FirstName = '"+DBNull.Value+"', LastName = '"+DBNull.Value+"', PhoneNumber = '"+DBNull.Value+"', CheckIn = '"+DBNull.Value+"', CheckOut = '"+DBNull.Value+"', ChekOut = '"+"EMPTY"+"', RoomStatus = '"+DBNull.Value+"' WHERE RoomID = '" + rIDBox.Text + "'";
                conn.Open();
                cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                search();
                MessageBox.Show("Đã xác nhận Check Out Thành công !", "Status");
            }
        }
    }
}
