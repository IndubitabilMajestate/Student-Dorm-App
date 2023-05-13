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
    public partial class StudentPage : Form
    {
        private int curr_id;
        DbMethods dbMethods;
        public StudentPage(int id)
        {
            this.curr_id = id;
            dbMethods = new DbMethods();
            InitializeComponent();

            StudentPage_RN_lbl.Text = dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["Room"].ToString();
        }

        private void StudentPage_SA_btn_Click(object sender, EventArgs e)
        {
            AnnComStudent annComStudent = new AnnComStudent(this.curr_id);
            annComStudent.Show();
        }

        private void StudentPage_SR_btn_Click(object sender, EventArgs e)
        {
            RoomPage studRoom = new RoomPage(this.curr_id);
            studRoom.Show();
        }

        private void StudentPage_RP_btn_Click(object sender, EventArgs e)
        {
            StudentPay stPay = new StudentPay(this.curr_id);

        }
    }
}
