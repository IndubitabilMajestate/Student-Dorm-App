using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminRents : Form
    {
        DbMethods dbMethods = new DbMethods();
        DataSet dsRents, dsPenalty;
        DataSet dsRentsPenalty = new DataSet();


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

            //SHOW ALL DATA WHEN PAGE LOADS

            dsRentsPenalty = dbMethods.ShowData("Students_Payments_RP");

            DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
            foreach (DataRow row in dtPayments.Rows)
            {
                String studentid = row["Student_Id"].ToString();
                String paymentid = row["Payment_Id"].ToString();
                String paid = row["Paid"].ToString();
                String paymentdate = row["PaymentDate"].ToString();
                String paymenttype = row["PaymentType"].ToString();
                String sumtopay = row["SumToPay"].ToString();
                dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True")?"Paid":"Not Paid", paymentdate, paymenttype, sumtopay);

            }

         
        }

        private void PaymentContent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchFilters_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Date_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_button_Click(object sender, EventArgs e)
        {

            String sfilter1 = SearchFilters_ComboBox.SelectedItem.ToString();
            String sfilter2 = comboBox1.SelectedItem.ToString();

            //Empty the data grid view
            dataGridView.Rows.Clear();


            //FILTER1 = ALL DATA
            if (sfilter1 == "Show all")
                //SHOW ALL DATA where type is Rent
                if (sfilter2 == "Show all")
                {
                    // assuming that the DataGridView control is named "myDataGridView"

                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_RP");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        String studentid = row["Student_Id"].ToString();
                        String paymentid = row["Payment_Id"].ToString();
                        String paid = row["Paid"].ToString();
                        String paymentdate = row["PaymentDate"].ToString();
                        String paymenttype = row["PaymentType"].ToString();
                        String sumtopay = row["SumToPay"].ToString();
                        dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);

                    }

                }
                //SHOW ALL DATA where type is Rent
                else
                    if (sfilter2 == "Rent")
                {
                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_Rent");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        String studentid = row["Student_Id"].ToString();
                        String paymentid = row["Payment_Id"].ToString();
                        String paid = row["Paid"].ToString();
                        String paymentdate = row["PaymentDate"].ToString();
                        String paymenttype = row["PaymentType"].ToString();
                        String sumtopay = row["SumToPay"].ToString();
                        dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);

                    }
                }
                //SHOW ALL DATA where type is Penalty
                else
                    if (sfilter2 == "Penalty")
                {
                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_Penalty");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        String studentid = row["Student_Id"].ToString();
                        String paymentid = row["Payment_Id"].ToString();
                        String paid = row["Paid"].ToString();
                        String paymentdate = row["PaymentDate"].ToString();
                        String paymenttype = row["PaymentType"].ToString();
                        String sumtopay = row["SumToPay"].ToString();
                        dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);

                    }
                }

            //FILTER1, ID
            if (sfilter1 == "Student ID")

                //SHOW RENTS AND PENALTIES OF GIVEN STUDENT
                if (sfilter2 == "Show all")
                {
                    // assuming that the DataGridView control is named "myDataGridView"

                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_RP");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        String studentid = row["Student_Id"].ToString();
                        if (studentid == textBox1.Text)
                        {
                            String paymentid = row["Payment_Id"].ToString();
                            String paid = row["Paid"].ToString();
                            String paymentdate = row["PaymentDate"].ToString();
                            String paymenttype = row["PaymentType"].ToString();
                            String sumtopay = row["SumToPay"].ToString();
                            dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);
                        }
                    }

                }
      
                //SHOW RENTS OF GIVEN STUDENT
                else
                    if (sfilter2 == "Rent")
                {
                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_Rent");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        String studentid = row["Student_Id"].ToString();
                        if (studentid == textBox1.Text)
                        {
                            String paymentid = row["Payment_Id"].ToString();
                            String paid = row["Paid"].ToString();
                            String paymentdate = row["PaymentDate"].ToString();
                            String paymenttype = row["PaymentType"].ToString();
                            String sumtopay = row["SumToPay"].ToString();
                            dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);
                        }
                    }
                }
                ////SHOW PENALTIES OF GIVEN STUDENT
                else
                    if (sfilter2 == "Penalty")
                {
                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_Penalty");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        String studentid = row["Student_Id"].ToString();

                        if (studentid == textBox1.Text)
                        {
                            String paymentid = row["Payment_Id"].ToString();
                            String paid = row["Paid"].ToString();
                            String paymentdate = row["PaymentDate"].ToString();
                            String paymenttype = row["PaymentType"].ToString();
                            String sumtopay = row["SumToPay"].ToString();
                            dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);
                        }
                    }
                }

            //FILTER1, MONTH
            if (sfilter1 == "Month")
            {
                int inputMonth = Convert.ToInt32(textBox1.Text);
         

                //SHOW RENTS AND PENALTIES OF GIVEN Month
                if (sfilter2 == "Show all")
                {
                    // assuming that the DataGridView control is named "myDataGridView"

                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_RP");
                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                   
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        DateTime month = (DateTime)row["PaymentDate"];
                        int monthNr = month.Month;

                        if (monthNr == inputMonth)
                        {
                            String studentid = row["Student_Id"].ToString();
                            String paymentid = row["Payment_Id"].ToString();
                            String paid = row["Paid"].ToString();
                            String paymentdate = row["PaymentDate"].ToString();
                            String paymenttype = row["PaymentType"].ToString();
                            String sumtopay = row["SumToPay"].ToString();
                            dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);
                        }
                    }

                }

                //SHOW RENTS OF GIVEN MONTH
                else
                    if (sfilter2 == "Rent")
                {
                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_Rent");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        DateTime month = (DateTime)row["PaymentDate"];
                        int monthNr = month.Month;

                        if (monthNr == inputMonth)
                        {
                            String studentid = row["Student_Id"].ToString();
                            String paymentid = row["Payment_Id"].ToString();
                            String paid = row["Paid"].ToString();
                            String paymentdate = row["PaymentDate"].ToString();
                            String paymenttype = row["PaymentType"].ToString();
                            String sumtopay = row["SumToPay"].ToString();
                            dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);
                        }
                    }
                }
                ////SHOW PENALTIES OF GIVEN STUDENT
                else
                    if (sfilter2 == "Penalty")
                {
                    dsRentsPenalty = dbMethods.ShowData("Students_Payments_Penalty");


                    DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
                    foreach (DataRow row in dtPayments.Rows)
                    {
                        DateTime month = (DateTime)row["PaymentDate"];
                        int monthNr = month.Month;

                        if (monthNr == inputMonth)
                        {
                            String studentid = row["Student_Id"].ToString();
                            String paymentid = row["Payment_Id"].ToString();
                            String paid = row["Paid"].ToString();
                            String paymentdate = row["PaymentDate"].ToString();
                            String paymenttype = row["PaymentType"].ToString();
                            String sumtopay = row["SumToPay"].ToString();
                            dataGridView.Rows.Add(studentid, paymentid, paid.Equals("True") ? "Paid" : "Not Paid", paymentdate, paymenttype, sumtopay);
                        }
                    }
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
