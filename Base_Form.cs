using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN
{
    public partial class Base_Form : Form
    {
        public Base_Form()
        {
            InitializeComponent();
        }

        private void btNVKS_Click(object sender, EventArgs e)
        {
            Login_Form staff = new Login_Form();
            staff.ShowDialog();
        }

        private void btKH_Click(object sender, EventArgs e)
        {
            Guest_Form guest = new Guest_Form();
            guest.ShowDialog();
        }
    }
}
