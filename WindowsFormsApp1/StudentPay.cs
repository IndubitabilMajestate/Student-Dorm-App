using StudentDormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class StudentPay : Form
    {

        int curr_id;
        DataSet dsPitch;
        DbMethods dbMethods = new DbMethods();

           
        int roomID;
        Image green = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");
        Image red = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\red.jpg");
        List<PictureBox> pictureBoxListPAY = new List<PictureBox>();
      

        public StudentPay(int id)
        {
            InitializeComponent();
            foreach (TabPage tabPage in Pay_tabControl.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is PictureBox)
                    {
                        pictureBoxListPAY.Add((PictureBox)control);
                        ((PictureBox)control).Image = green;
                    }
                }



                this.curr_id = id;
            }
           // GetReservations();
    
        }

        public void GetReservations()
        {
            int dayOfWeek;
            dsPitch = dbMethods.ShowData("PitchReservations");
           
            DataTable dtPitchReservations = dsPitch.Tables[0];
            foreach (DataRow row in dtPitchReservations.Rows)
            {
                DateTime date_time = (DateTime)row["DateOfRes"];   //MessageBox.Show("Whole date_time" + date_time);
                int time = date_time.Hour;   //MessageBox.Show(" time = " + time);//linie
                if(date_time.DayOfWeek == 0)
                     dayOfWeek = (int)date_time.DayOfWeek;   //MessageBox.Show(" day week = " + dayOfWeek);//coloana 
                else
                {
                    dayOfWeek = 7 - (int)date_time.DayOfWeek;
                }

                int timeFINAL = (20 - time) / 2;
                int numarP = timeFINAL * 7 +dayOfWeek ;
                pictureBoxListPAY.ElementAt(numarP).Image = red;
              
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void StPayRent_Button_Click(object sender, EventArgs e)
        {
            dbMethods.AddPayments(int.Parse(textBox2.Text), SearchFilters_ComboBox.SelectedItem.ToString(), int.Parse(Sum_Box1.Text));
        }

        private void StPayFacilities_Button_Click(object sender, EventArgs e)
        {
            int dayOfWeek =0;
            String selection = comboBox2.SelectedItem.ToString();
            switch(selection)
            {
                case "Monday":
                    dayOfWeek = 1;
                break;

                case "Tuesday":
                    dayOfWeek = 2;
                break;

                case "Wednesday":
                    dayOfWeek = 3;
                break;

                case "Thursday":
                    dayOfWeek = 4;
                break;

                case "Friday":
                    dayOfWeek = 5;
                break;

                case "Saturday":
                    dayOfWeek = 6;
                break;

                case "Sunday":
                    dayOfWeek = 0;
                break;
            }

            DateTime date = DateTime.Now.Date; // get the current date without the time component
            int daysUntilReservation = ((dayOfWeek - (int)date.DayOfWeek + 7) % 7); // calculate the number of days until wanted day
            DateTime reservationDate = date.AddDays(daysUntilReservation); // add the number of days to get the next Tuesday

            String timeSelected = comboBox1.SelectedItem.ToString();
            DateTime time = DateTime.Parse("00:00");

            switch (timeSelected)
            {
                case "8:00 - 10:00":
                    time = DateTime.Parse("8:00");
                    break;

                case "10:00 - 12:00":
                    time = DateTime.Parse("10:00");
                    break;

                case "12:00 - 14:00":
                    time = DateTime.Parse("12:00");
                    break;

                case "14:00 - 16:00":
                    time = DateTime.Parse("14:00");
                    break;

                case "16:00 - 18:00":
                    time = DateTime.Parse("16:00");
                    break;

                case "18:00 - 20:00":
                    time = DateTime.Parse("18:00");
                    break;

                case "20:00 - 22:00":
                    time = DateTime.Parse("20:00");
                    break;
            }

            DateTime reservationDateTime = reservationDate.Add(time.TimeOfDay);

            //Add the payment
             dbMethods.AddPayments(int.Parse(textBox2.Text), Facilities_ComboBox.SelectedItem.ToString(), int.Parse(Sum_Box2.Text));


            //Add the reservation
            if (Facilities_ComboBox.SelectedItem.ToString() == "Football Pitch")
            {
                dbMethods.AddPitchReservation(int.Parse(textBox2.Text), reservationDateTime, time);
            }else
                dbMethods.AddPoolReservation(int.Parse(textBox2.Text), reservationDateTime);

        }

        private void Refersh_button_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in Pay_tabControl.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is PictureBox)
                    {
                        pictureBoxListPAY.Add((PictureBox)control);
                        ((PictureBox)control).Image = green;
                    }
                }



                this.curr_id = curr_id;
            }

            GetReservations();
        }

        private void StudentPay_Load(object sender, EventArgs e)
        {
            DataSet dsRentsPenalty = dbMethods.SearchRPByStudentId(2);
           
            String text = "";
        
            DataTable dtPayments = dsRentsPenalty.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
            foreach (DataRow row in dtPayments.Rows)
            {
                String paymentid = row["Payment_Id"].ToString();
                String paid = row["Paid"].ToString();
                if (paid == "True")
                    paid = "Paid";
                else
                    paid = "Not paid";
                String paymentdate = row["PaymentDate"].ToString();
                String paymenttype = row["PaymentType"].ToString();
                String sumtopay = row["SumToPay"].ToString();
       
                text =  paymentid + "  " + paid + "  " + paymentdate + "   " + paymenttype + "    " +sumtopay+"\n";
                listBox1.Items.Add(text);
            }


           
            DataSet dsPoolRes = dbMethods.SearchPoolResByStudent(2);

            DataTable dtPoolRes = dsPoolRes.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
            foreach (DataRow row in dtPoolRes.Rows)
            {
               
                String paymentdate = row["DateOfRes"].ToString();
              
                text = "Pool reservation at: " + paymentdate +"\n";
                listBox2.Items.Add(text);
            }

            listBox2.Items.Add("Payment receipts:\n ");
            DataSet dsPoolPay = dbMethods.SearchPoolPayByStudentId(2);

            DataTable dtPoolPay = dsPoolPay.Tables[0]; // Assuming that the "Students_Payments" table is the first table in the DataSet
            foreach (DataRow row in dtPoolPay.Rows)
            {
                String paymentid = row["Payment_Id"].ToString();
                String paid = row["Paid"].ToString();
                if (paid == "True")
                    paid = "Paid";
                else
                    paid = "Not paid";
                String paymentdate = row["PaymentDate"].ToString();
                String paymenttype = row["PaymentType"].ToString();
                String sumtopay = row["SumToPay"].ToString();

                text = paymentid + "  " + paid + "  " + paymentdate + "   " + paymenttype + "    " + sumtopay + "\n";
                listBox2.Items.Add(text);

            }

         
            
        }

    }
}
