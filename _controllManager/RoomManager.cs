using DOAN._Class;
using System;
using System.Collections;
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
    public partial class RoomManager : UserControl
    {
        function fn = new function();
        String querry;
        public RoomManager()
        {
            InitializeComponent();
        }

        private void RoomManager_Load(object sender, EventArgs e)
        {
            querry = "select * from Room_Info";
            DataSet ds = fn.getData(querry);
            dataRoomManage.DataSource = ds.Tables[0];
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtIDRoom.Text != "" && cbTypeRoom.Text != "" && txtPriceRoom.Text != "")
            {
                String idRoom = txtIDRoom.Text;
                String typeBed = cbTypeBed.Text;
                String typeRoom = cbTypeRoom.Text;
                Int64 price = Convert.ToInt64(txtPriceRoom.Text);

                querry = "insert into Room_Info (RoomID, RoomType, RoomBed, RoomPrice) values('" + idRoom + "','" + typeRoom + "', '" + typeBed + "', " + price + ")";
                fn.setData(querry, "Add room successfully!!!");

                RoomManager_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please fill in all the information!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            txtIDRoom.Clear();
            cbTypeBed.SelectedIndex = 0;
            cbTypeRoom.SelectedIndex = 0;
            txtPriceRoom.Clear();
        }

        private void RoomManager_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void RoomManager_Enter(object sender, EventArgs e)
        {
            RoomManager_Load(this, null);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (txtIDRoom.Text != "")
            {
                String idRoom = txtIDRoom.Text;
                querry = "DELETE FROM Room_Info WHERE RoomID = " + idRoom + "";
                fn.setData(querry, "Data deleted successfully!");
                RoomManager_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please fill in the information IDRoom!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtIDRoom.Text != "" && cbTypeRoom.Text != "" && txtPriceRoom.Text != "")
            {
                String idRoom = txtIDRoom.Text;
                String typeBed = cbTypeBed.Text;
                String typeRoom = cbTypeRoom.Text;
                Int64 price = Convert.ToInt64(txtPriceRoom.Text);

                querry = "update Room_Info set RoomBed = '" + typeBed + "', RoomType = '" + typeRoom + "', RoomPrice =  " + price + " where RoomID = '" + idRoom +"'";
                fn.setData(querry, "Data UPDATE successfully!!!");

                RoomManager_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Please fill in all the information want to UPDATE!!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}