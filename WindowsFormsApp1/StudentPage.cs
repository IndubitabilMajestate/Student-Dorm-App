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
        public StudentPage(int id)
        {
            this.curr_id = id;
            
            InitializeComponent();
            StudentPage_RN_lbl.Text = curr_id.ToString();
        }

        private void StudentPage_SA_btn_Click(object sender, EventArgs e)
        {
            this.Open_AnnComp();
        }

        private void StudentPage_MC_btn_Click(object sender, EventArgs e)
        {
            this.Open_AnnComp();
        }

        private void StudentPage_SR_btn_Click(object sender, EventArgs e)
        {
            RoomPage studRoom = new RoomPage(curr_id);
            studRoom.Show();
        }


        private void Open_AnnComp()
        {
            AnnComStudent annComStudent = new AnnComStudent(this.curr_id);
            annComStudent.Show();
        }

        private void AdminPage_R_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void AdminPage_RP_btn_Click(object sender, EventArgs e)
        {
            StudentPay stPay = new StudentPay(this.curr_id);

        }
    }
}
