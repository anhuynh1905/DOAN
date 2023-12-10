using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DOAN._controllManager
{
    public partial class FeedBack : UserControl
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (txtFirst.Text != "" && txtLast.Text != "" && txtPhone.Text != "" && txtRoomID.Text != "" && date.Text != "" && txtSatis.Text != "" && txtComment.Text != "" && txtFuture.Text != "")
            {
                string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\OOP_22162001\\Project\\anhuynh1905\\DOAN\\_data\\hotel_db.mdf;Integrated Security=True";
                string query = "insert into Feed_Info (FirstName, LastName, PhoneNumber, RoomID, DateFB, Satis, Comment, Future) values('" + txtFirst.Text + "', '" + txtLast.Text + "', '" + txtPhone.Text + "','" + txtRoomID.Text + "', '" + date.Text + "', '" + txtSatis.Text + "', '" + txtComment.Text + "', '" + txtFuture.Text + "')";
                SqlConnection db = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand(query, db);
                SqlDataReader sdr;
                try
                {
                    db.Open();
                    sdr = cmd.ExecuteReader();
                    MessageBox.Show("Send FeedBack successfully!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    while (sdr.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please fill in all the information!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            txtFirst.Clear();
            txtLast.Clear();
            txtPhone.Clear();
            txtRoomID.Clear();
            date.ResetText();
            txtSatis.SelectedIndex = 2;
            txtComment.Clear();
            txtFuture.SelectedIndex = 0;
        }
    }
}
