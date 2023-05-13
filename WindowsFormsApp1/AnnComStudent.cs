using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace StudentDormApp
{
    public partial class AnnComStudent : Form
    {
        private int curr_id;
        DbMethods dbMethods = new DbMethods();
        public AnnComStudent(int id)
        {
            this.curr_id = id;
            InitializeComponent();
        }

        private void AnnComPage_CC_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title",typeof(string));
            dt.Columns.Add("Content", typeof(string));
            dt.Columns.Add("RoomId", typeof(int));
            dt.Columns.Add("Solved", typeof(bool));


            DataRow dr = dt.NewRow();

            dr["Id"] = curr_id + DateTime.Now.Hour*10000000 +DateTime.Now.Minute*100000 + DateTime.Now.Second*1000;
            dr["Title"] = AnnComPage_CCT_tb.Text;
            dr["Content"]= AnnComPage_CCC_tb.Text;
            dr["RoomId"] = dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["Room"];
            dr["Solved"] = false;
            MessageBox.Show(dr["Id"].ToString() + " " + dr["Title"].ToString() + " " + dr["Content"].ToString() + " " + dr["RoomId"].ToString() + " " + dr["Solved"].ToString() + " ");
            dbMethods.AddComplaint(dr);
        }

    }
}
