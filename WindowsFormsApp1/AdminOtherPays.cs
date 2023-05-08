using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDormApp
{
    public partial class AdminOtherPays : Form
    {
        public AdminOtherPays()
        {
            InitializeComponent();
            this.Init();
           
        }
        
        private void Init()
        {
            Date_textBox.Text = DateTime.Now.Date.ToString("d");
            Time_textBox.Text = DateTime.Now.ToString("HH:mm:ss");

            DateTime tenthDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 10);
            LastDay_textBox.Text = tenthDay.ToString("yyyy-MM-dd");

        }

        private void AdminOtherPays_Load(object sender, EventArgs e)
        {

        }
    }
}
