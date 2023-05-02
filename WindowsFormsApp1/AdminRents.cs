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
    public partial class AdminRents : Form
    {
        

        public AdminRents()
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

        private void Rents_Load(object sender, EventArgs e)
        {
            //select data from Students_Payments where Paid=1
            //Student id, date, time, Sum to Pay
        }

        private void PaymentContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchFilters_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Date_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
