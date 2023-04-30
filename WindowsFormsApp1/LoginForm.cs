using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string[] studentData = dbMethods.ShowData("Students");
            string message = String.Join("\n", studentData);
            MessageBox.Show(message);
        }
    }
}
