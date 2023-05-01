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
    public partial class StudentPay : Form
    {
        int Rent = 220; //lei
        int DayPenalty = 2; //lei

        public StudentPay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StPayRent_Button_Click(object sender, EventArgs e)
        {
            String PayType = SearchFilters_ComboBox.SelectedItem.ToString();

            if (PayType == "Rent")
            {
                //add the data into Students_Payments Table;
                //Penalty = 0 lei paid
            }
            else
                if (PayType == "Penalties")
            {
                //delete the penalty from Students_Penalties database
            }
            else
            {
                //Rent&Penalties case

                //Calc the how much is the penalty from the total sum
                double penalty = Convert.ToDouble(Sum_Box1.Text) - Rent;

                //add the data into Students_Payments Table;
                //delete the penalty from  Students_Penalties database based on the value paid



            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SearchFilters_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StPayFacilities_Button_Click(object sender, EventArgs e)
        {
            String PayType = Facilities_ComboBox.SelectedItem.ToString();

            if (PayType == "Football Pitch")
            {
                //add the data into Students_Payments Table;
                //Penalty = 0 lei paid
                // fac un grid din ala ca la spalatorie, cand se plateste se face rosu, adica se ocupa

                string theDate = FacilitiesPay_dp.Value.ToShortDateString();
                string time = FacilitiesPay_TextBox.Text.ToString();
                

                //using date and time 
            }
            else
                if (PayType == "Swimming Pool entry")
            {
                //add the data into Students_Payments Table;
                //Penalty = 0 lei paid
            }

        }
    }
}
