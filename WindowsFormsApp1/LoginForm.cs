using StudentDormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrontPage_Form : Form
    {
        private DbMethods dbMethods;
        
        public FrontPage_Form()
        {
            InitializeComponent();
            dbMethods = new DbMethods();
           // string[] studentData = dbMethods.ShowData("Students");
            DataSet renttest = dbMethods.ShowData("Students_Payments_Rent");
            MessageBox.Show(renttest.GetXml());
           // string message = String.Join("\n", studentData);
           
        }

        private void FrontPage_LI_btn_Click(object sender, EventArgs e)
        {
            string[] errors = { "No username.", "No Password", "No type selected", "Invalid Username", "Invalid Password"};
            if( returnLoginError() == -1)
            {
                if(FrontPage_AD_rbtn.Checked )
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {

                    StudentPage studentForm = new StudentPage( /*getUserRoom()*/ 1);
                    studentForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(errors[returnLoginError()]);
            }
        }

        private int returnLoginError()
        {
            if(FrontPage_UN_tb.Text == "")
            {
                return 0;
            }
            if(FrontPage_PW_tb.Text == "") 
            {
                return 1;
            }
            if(!FrontPage_ST_rbtn.Checked  && !FrontPage_AD_rbtn.Checked) 
            {
                return 2;
            }
            if(FrontPage_AD_rbtn.Checked && FrontPage_UN_tb.Text != "test")
            {
                return 3;
            }
            if(FrontPage_ST_rbtn.Checked && FrontPage_PW_tb.Text != "pass")
            {
                return 4;
            }
            return -1;
        }

        
    }
}
