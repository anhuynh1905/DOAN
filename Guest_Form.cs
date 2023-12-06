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

namespace DOAN
{
    public partial class Guest_Form : Form
    {
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\OOP_22162001\\Project\\DOAN\\DOAN\\_data\\hotel_db.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
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
            GuestClassesDataContext db = new GuestClassesDataContext();
            var list = (from s in db.Room_Infos where s.RoomStatus.ToString().Trim() == "TRUE" select s).ToList();
            datagridview.DataSource = list;
        }

        private void Book_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(CheckIn.Value < now)
            {
                Statuslable.Text = "Thông tin ngày chưa hợp lệ, xin nhập lại";
                return;
            }
            if(fNameBox.Text == "" || lNameBox.Text == "" || pNumberBox.Text == "" || RoomBox.Text == "")
            {
                Statuslable.Text = "Vui lòng nhập đủ thông tin";
                return;
            }
            conn.Open();
            command = String.Format("SELECT RoomStatus FROM Room_Info WHERE RoomID = '" + "{0}" + "'", Int32.Parse(RoomBox.Text));
            cmd = new SqlCommand(command, conn);
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                if (Convert.ToString(reader["RoomStatus"]).Trim() == "FALSE")
                {
                    Statuslable.Text = "Phòng đã có người chọn, vui lòng chọn phòng khác";
                    reader.Close();
                    conn.Close();
                    cmd.Dispose();
                    return;
                }
            }
            reader.Close();
            insert = String.Format("UPDATE Room_Info SET FirstName='"+"{0}"+"', LastName='"+"{1}"+"', PhoneNumber='"+"{2}"+"', CheckIn='"+"{3}"+"', CheckOut='"+"{4}"+"', RoomStatus='"+"FALSE"+ "' WHERE RoomID='"+"{5}"+"'",
                        fNameBox.Text, lNameBox.Text, pNumberBox.Text, CheckIn.Value, CheckOut.Value,Int32.Parse(RoomBox.Text));
            cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();

            Statuslable.Text = "Đã đặt phòng thành công";
            conn.Close();
            cmd.Dispose();
            Guest_Form_Load(sender, e);
        }
    }
}
