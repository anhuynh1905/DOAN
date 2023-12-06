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
        static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\OOP_22162001\\Project\\DOAN\\DOAN\\DatabaseRoom1.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd;
        string command;
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
            // TODO: This line of code loads data into the 'hotel_dbDataSet1.Room_Info' table. You can move, or remove it, as needed.
            //this.room_InfoTableAdapter1.Fill(this.hotel_dbDataSet1.Room_Info);
            GuestClassesDataContext db = new GuestClassesDataContext();
            var list = (from s in db.Room_Infos where s.RoomStatus.ToString().Trim() == "TRUE" select s).ToList();
            datagridview.DataSource = list;
        }

        private void Book_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if(CheckIn.Value < now)
            {
                MessageBox.Show("Ngày không hợp lệ, vui lòng nhập lại ngày", "Status");
                return;
            }
            GuestClassesDataContext db = new GuestClassesDataContext();
            Room_Info customer = new Room_Info();
            customer = db.Room_Infos.Where(s => s.RoomID == Int32.Parse(RoomBox.Text)).Single();
            customer.FirstName = fNameBox.Text;
            customer.LastName = lNameBox.Text;
            customer.PhoneNumber = pNumberBox.Text;
            customer.CheckOut = CheckOut.Value;
            customer.CheckIn = CheckIn.Value;
            customer.ChekOut = "False";
            customer.RoomStatus = "False";
            db.SubmitChanges();
            Guest_Form_Load(sender, e);
        }
    }
}
