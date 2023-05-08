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
        DbMethods dbMethods = new DbMethods();
        DataSet dsPayments;

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

            dsPayments = dbMethods.ShowData("Students_Payments");
            //MessageBox.Show(dsPayments.GetXml());

            DataTable dtPayments = dsPayments.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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

            /*
            //MessageBox.Show(dsPayments.ToString());

            foreach (DataRow dr in dsPayments.Tables["Students_Payments"].Rows)
            {
                String studentid = Convert.ToString(dr.ItemArray.GetValue(0));
                String paymentid = Convert.ToString(dr.ItemArray.GetValue(1));
                String paid = Convert.ToString(dr.ItemArray.GetValue(2));
                String paymentdate = Convert.ToString(dr.ItemArray.GetValue(3));
                String paymenttype = Convert.ToString(dr.ItemArray.GetValue(4));
                String sumtopay = Convert.ToString(dr.ItemArray.GetValue(5));
                PaymentContent.Items.Add(studentid + "    " + paymentid + "   " + paid + "    " + paymentdate + "  " + paymenttype + "    " + sumtopay);

            }
            */
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


            //SHOW ALL DATA AT REQUEST
            if(sfilter1 == "Show all" && sfilter2 == "Show all")
            {
                dsPayments = dbMethods.ShowData("Students_Payments");
               

                DataTable dtPayments = dsPayments.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
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
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
