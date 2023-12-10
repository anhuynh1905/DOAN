using DOAN._Class;
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

        private void btCheckout_Click(object sender, EventArgs e)
        {
            checkOut1.Visible = true;
            checkOut1.BringToFront();
        }

        private void Receptionist_Form_Load(object sender, EventArgs e)
        {
            checkOut1.Visible = false;
            checkIn1.Visible = false;
        }

        private void btCheckin_Click(object sender, EventArgs e)
        {
            checkIn1.Visible = true;
            checkIn1.BringToFront();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            string h = "";
            h += StaffCombo.PrintDetails("") + Environment.NewLine;
            MessageBox.Show(h, "Booking Details");
        }
    }
}
