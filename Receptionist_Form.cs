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
    public partial class Receptionist_Form : Form
    {
        public Receptionist_Form()
        {
            InitializeComponent();
        }

        private void btExitRecep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
