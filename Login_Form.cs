using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Login_Form : Form
    {
        static string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\OOP_22162001\\Project\\DOAN\\DOAN\\DatabaseRoom1.mdf;Integrated Security=True";
        SqlConnection sql = new SqlConnection(cn);
        SqlCommand cmd;
        SqlDataReader rdr;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            GuestClassesDataContext db = new GuestClassesDataContext();
            try
            {
                staff = db.Staffs.Where(s => s.UserName.ToString().Trim() == txtUser.Text && 
                s.PassWord.ToString().Trim() == txtPass.Text && s.Role.ToString().Trim() == cbPermiss.Text.Trim()).Single();
            }
            catch 
            {
                lbStatus.Visible = true;
                txtPass.Clear();
                return;
            }
            if(staff.Role.ToString().Trim() == "Manager" )
            {
                Manager_Form manager = new Manager_Form();
                this.Hide();
                //manager.ShowDialog();
            }
            else
            {
                Receptionist_Form recep = new Receptionist_Form();
                this.Hide();
                //recep.ShowDialog();
            }

            /*
            if (txtUser.Text == "anhan" && txtPass.Text == "spkt123" && cbPermiss.Text == "Manager")
            {
                lbStatus.Visible = false;
                Manager_Form manager = new Manager_Form();
                this.Hide();
                manager.ShowDialog();
            }
            else if (txtUser.Text == "anhphuong" && txtPass.Text == "spkt123" && cbPermiss.Text == "Receptionist")
            {
                lbStatus.Visible = false;
                Receptionist_Form recep = new Receptionist_Form();
                this.Hide();
                recep.ShowDialog();
            }
            else
            {
                lbStatus.Visible = true;
                txtPass.Clear();
            }
            */
        }
    }
}
