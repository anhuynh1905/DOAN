using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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
            else
            {
                lbStatus.Visible = true;
                txtPass.Clear();
            }
        }
    }
}
