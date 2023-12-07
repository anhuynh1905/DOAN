using DOAN._Class;
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

namespace DOAN._controllManager
{
    public partial class CheckIn : UserControl
    {
        function fn = new function();
        String querry;

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        public CheckIn()
        {
            InitializeComponent();
        }

        private void CheckIn_Load(object sender, EventArgs e)
        {

        }

        private void cbTRcin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIDcin.Items.Clear();
            querry = "select RoomID from Room_Info where RoomBed = '" + cbBed.Text + "' and RoomType = '" + cbTRcin.Text + "' and RoomStatus = 'TRUE'";
            setComboBox(querry, cbIDcin);
        }
        int rid;
        private void cbIDcin_SelectedIndexChanged(object sender, EventArgs e)
        {
            querry = "select RoomPrice, RoomID from Room_Info where RoomID = '" + cbIDcin.Text + "'";
            DataSet ds = fn.getData(querry);
            txtPcin.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btConfirmCIN_Click(object sender, EventArgs e)
        {
            if (txtFNcin.Text != "" && txtLNcin.Text != "" && txtPNcin.Text != "")
            {
                String firstname = txtFNcin.Text;
                String lastname = txtLNcin.Text;
                Int64 mobile = Int64.Parse(txtPNcin.Text);
                String timeCI = timeCheckIn.Text;

                querry = "insert into Room_Info (FirstName, LastName, PhoneNumber, CheckIn) values ('" + firstname + "', '" + lastname + "', " + mobile + ", '" + timeCI +"') update Room_Info set RoomStatus = 'FALSE' where RoomID = '" + cbIDcin.Text + "'";
                fn.setData(querry, "Check_In successfully!");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please fill in all the information!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            txtFNcin.Clear();
            txtLNcin.Clear();
            txtPNcin.Clear();
            timeCheckIn.ResetText();
            cbBed.SelectedIndex = -1;
            cbTRcin.SelectedIndex = -1;
            cbIDcin.Items.Clear();
            txtPcin.Clear();
        }

        private void cbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTRcin.SelectedIndex = -1;
            cbIDcin.Items.Clear();
            txtPcin.Clear();
        }
    }
}
