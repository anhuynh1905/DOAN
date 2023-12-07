using DOAN._Class;
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
        static string cn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Tran Dong Phuong\\OneDrive\\Desktop\\DOAN\\_data\\hotel_db.mdf\";Integrated Security=True";
        SqlConnection sql = new SqlConnection(cn);
        SqlCommand cmd;
        SqlDataReader rdr;
        List<Manager> managers = new List<Manager>();
        List<Receptionist> receptionists = new List<Receptionist>();
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
                managers.Add(new Manager(staff.UserName.ToString().Trim(), staff.PassWord.ToString().Trim(), staff.Role.ToString().Trim(),
                    staff.FirstName.ToString().Trim(), staff.LastName.ToString().Trim(), staff.PhoneNumber.ToString().Trim()));
                Manager_Form manager = new Manager_Form();
                this.Hide();
                manager.ShowDialog();
            }
            else
            {
                receptionists.Add(new Receptionist(staff.UserName.ToString().Trim(), staff.PassWord.ToString().Trim(), staff.Role.ToString().Trim(),
                    staff.FirstName.ToString().Trim(), staff.LastName.ToString().Trim(), staff.PhoneNumber.ToString().Trim()));
                Receptionist_Form recep = new Receptionist_Form();
                this.Hide();
                recep.ShowDialog();
            }
        }
    }
}
