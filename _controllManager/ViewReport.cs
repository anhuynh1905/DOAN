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
    public partial class ViewReport : UserControl
    {
        function fn = new function();
        String query;
        public ViewReport()
        {
            InitializeComponent();
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            query = "select Feed_Info.FirstName, Feed_Info.LastName, Feed_Info.PhoneNumber, Feed_Info.RoomID, Feed_Info.DateFB, Feed_Info.Satis, Feed_Info.Comment, Feed_Info.Future from Feed_Info";
            DataSet ds = fn.getData(query);
            feedback.DataSource = ds.Tables[0];
        }
    }
}
