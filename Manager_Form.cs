using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btManage_Click(object sender, EventArgs e)
        {
            roomManager1.Visible = true;
            roomManager1.BringToFront();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {
            roomManager1.Visible = false;
        }
    }
}
