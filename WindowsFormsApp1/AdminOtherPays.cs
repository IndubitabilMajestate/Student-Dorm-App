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
    public partial class AdminOtherPays : Form
    {
        DbMethods dbMethods = new DbMethods();
        DataSet dsPitch, dsPool;
        DataSet dsPitchPool = new DataSet();
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
            //SHOW ALL DATA WHEN PAGE LOADS
            dsPitchPool = dbMethods.ShowData("Students_Payments_PitchPool");

            DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that it is ok
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

       

        private void Search_button_Click(object sender, EventArgs e)
        {
            String sfilter1 = SearchFilters_ComboBox.SelectedItem.ToString();
            String sfilter2 = comboBox1.SelectedItem.ToString();


            //Empty the data grid view
            dataGridView.Rows.Clear();

            //FILTER1 = ALL DATA
            if (sfilter1 == "Show all")
                if (sfilter2 == "Show all")
                {
                    // assuming that the DataGridView control is named "myDataGridView"

                    dsPitchPool = dbMethods.ShowData("Students_Payments_PitchPool");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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
                //SHOW ALL DATA where type is Pitch
                else
                    if (sfilter2 == "Football Pitch")
                {
                    dsPitchPool = dbMethods.ShowData("Students_Payments_Pitch");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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
                    if (sfilter2 == "Swimming Pool")
                {
                    dsPitchPool = dbMethods.ShowData("Students_Payments_Pool");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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

                    dsPitchPool = dbMethods.ShowData("Students_Payments_PitchPool");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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

                //SHOW PITCH RESERVATIONS OF GIVEN STUDENT
                else
                    if (sfilter2 == "Football Pitch")
                {
                    dsPitchPool = dbMethods.ShowData("Students_Payments_Pitch");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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
                ////SHOW pOOL RESERVATIONS OF GIVEN STUDENT
                else
                    if (sfilter2 == "Swimming Pool")
                {
                    dsPitchPool = dbMethods.ShowData("Students_Payments_Pool");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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


                //SHOW FOOTBAL PITCH AND SWIMMING POOL RESERVATIONS OF GIVEN MONTH
                if (sfilter2 == "Show all")
                {
                    // assuming that the DataGridView control is named "myDataGridView"

                    dsPitchPool = dbMethods.ShowData("Students_Payments_PitchPool");
                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet

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

                //SHOW FOOTBALL PITCH RESERVATIONS OF GIVEN MONTH
                else
                    if (sfilter2 == "Football Pitch")
                {
                    dsPitchPool = dbMethods.ShowData("Students_Payments_Pitch");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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
                ////SHOW SWIMMMING POOL RESERVATIONS OF GIVEN STUDENT
                else
                    if (sfilter2 == "Swimming Pool")
                {
                    dsPitchPool = dbMethods.ShowData("Students_Payments_Pool");


                    DataTable dtPayments = dsPitchPool.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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

    }
}
