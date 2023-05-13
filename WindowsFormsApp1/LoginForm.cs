using StudentDormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrontPage_Form : Form
    {
        private DbMethods dbMethods;
        private int curr_id;
        
        public FrontPage_Form()
        {
            InitializeComponent();
            dbMethods = new DbMethods();
        }

        private void FrontPage_LI_btn_Click(object sender, EventArgs e)
        {
            string[] errors = { "No username.", "No Password", "No type selected", "Invalid Username", "Invalid Password"};
            if( ReturnLoginError() == -1)
            {
                if(FrontPage_AD_rbtn.Checked )
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    this.curr_id = (int)dbMethods.GetbyUser(FrontPage_UN_tb.Text, FrontPage_ST_rbtn.Checked ? "Students" : "Admin_Login").Tables[0].Rows[0]["Id"];
                    StudentPage studentForm = new StudentPage(curr_id);
                    studentForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(errors[ReturnLoginError()]);
            }
        }

        private int ReturnLoginError()
        {
            if(FrontPage_UN_tb.Text == "") return 0;
            if(FrontPage_PW_tb.Text == "") return 1;
            if(!FrontPage_ST_rbtn.Checked  && !FrontPage_AD_rbtn.Checked) return 2;
            if(FrontPage_UN_tb.Text != "")
            {
                try
                {
                    string pw = dbMethods.GetbyUser(FrontPage_UN_tb.Text, FrontPage_ST_rbtn.Checked ? "Students" : "Admin_Login").Tables[0].Rows[0]["Password"].ToString();
                    if (pw == FrontPage_PW_tb.Text) return -1;
                    else return 4;
                }
                catch (Exception ex) {
                    return 3;
                }
                
            }
            return -1;
        }
    }
}
