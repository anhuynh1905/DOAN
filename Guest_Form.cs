using DOAN._controllManager;
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
            // TODO: This line of code loads data into the 'databaseRoom1DataSet1.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter1.Fill(this.databaseRoom1DataSet1.rooms);
            // TODO: This line of code loads data into the 'databaseRoom1DataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.databaseRoom1DataSet.rooms);

        }

        private void Book_Click(object sender, EventArgs e)
        {
            customer cs = new customer();
            GuestClassesDataContext db = new GuestClassesDataContext();
            cs.clname = lNameBox.Text;
            cs.checkout = CheckOut.Value;
            cs.checkin = CheckIn.Value;
            cs.cfname = fNameBox.Text;
            db.customers.InsertOnSubmit(cs);
            db.SubmitChanges();
        }
    }
}
