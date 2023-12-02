using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }
    }
}
