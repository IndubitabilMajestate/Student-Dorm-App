﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Rents : Form
    {
        private DbMethods dbMethods;
        public Rents()
        {
            InitializeComponent();
            dbMethods = new DbMethods();
            //dbMethods.ShowData("Students_Payments_Rent");

        }

        private void Rents_Load(object sender, EventArgs e)
        {

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
    }
}
