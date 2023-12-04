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

        private void cbTBcin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTRcin.SelectedIndex = -1;
            cbIDcin.Items.Clear();
            txtPcin.Clear();
        }

        private void cbTRcin_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIDcin.Items.Clear();
            querry = "select roomNo from rooms where bed = '" + cbTBcin.Text + "' and roomType = '" + cbTRcin.Text + "' and booked = 'NO'";
            setComboBox(querry, cbIDcin);
        }
        int rid;
        private void cbIDcin_SelectedIndexChanged(object sender, EventArgs e)
        {
            querry = "select price, roomid from rooms where roomNo = '" + cbIDcin.Text + "'";
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

                querry = "insert into customer (cfname, clname, mobile, checkin, roomid) values ('" + firstname + "', '" + lastname + "', " + mobile + ", '" + timeCI +"', " + rid + ") update rooms set booked = 'YES' where roomNo = '" + cbIDcin.Text + "'";
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
            cbTBcin.SelectedIndex = -1;
            cbTRcin.SelectedIndex = -1;
            cbIDcin.Items.Clear();
            txtPcin.Clear();
        }
    }
}
