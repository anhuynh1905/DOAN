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

namespace DOAN._controllManager
{
    public partial class CheckOut : UserControl
    {
        function fn = new function();
        String querry;
        public CheckOut()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            querry = "select Room_Info.LastName, Room_Info.PhoneNumber, Room_Info.CheckIn, Room_Info.RoomNo, Room_Info.RoomStatus, Room_Info.RoomType, Room_Info.RoomPrice, Room_Info.RoomBed from Room_Info where ChekOut = 'NO'";
            DataSet ds = fn.getData(querry);
            dataCheckOut.DataSource = ds.Tables[0];
        }

        private void txtEnter_TextChanged(object sender, EventArgs e)
        {
            querry = "select Room_Info.LastName, Room_Info.PhoneNumber, Room_Info.CheckIn, Room_Info.RoomNo, Room_Info.RoomStatus, Room_Info.RoomType, Room_Info.RoomPrice, Room_Info.RoomBed from Room_Info where LastName like = '" + txtEnter.Text + "' and ChekOut = 'NO'";
            DataSet ds = fn.getData(querry);
            dataCheckOut.DataSource = ds.Tables[0];
        }
        int id;
        private void dataCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataCheckOut.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(dataCheckOut.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNameGuest.Text = dataCheckOut.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomGuest.Text = dataCheckOut.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btConfirmCOut_Click(object sender, EventArgs e)
        {
            if (txtNameGuest.Text != "")
            {
                if (MessageBox.Show("Are you sure to CheckOut?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = timeCheckOut.Text;
                    querry = "update Room_Info set ChekOut = 'YES' where LastName = '" + txtNameGuest.Text + "' update Room_Info set RoomStatus = 'NO' where RoomNo = '" + txtRoomGuest.Text + "'";
                    fn.setData(querry, "CheckOut successfully!");
                    CheckOut_Load(this, null);
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("No customer information for payment!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            txtEnter.Clear();
            txtNameGuest.Clear();
            txtRoomGuest.Clear();
            timeCheckOut.ResetText();
        }
    }
}
