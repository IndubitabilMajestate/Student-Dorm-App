using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class WashingRoom : Form
    {
        DataSet dsWashingRoom;
        DbMethods dbMethods = new DbMethods();
        public bool[,,] seats = new bool[7, 7, 5];

        int roomID;
        Image green = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");
        Image red = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\red.jpg");

        List<PictureBox> pictureBoxList = new List<PictureBox>();

        public WashingRoom(int id)
        {
            InitializeComponent();
            this.roomID = id;


            foreach (TabPage tabPage in WashM_tabControl.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is PictureBox)
                    {
                        pictureBoxList.Add((PictureBox)control);
                    }
                }
            }

            for (int i = 0; i < 245; i++)
            {
                this.pictureBoxList[i].Image = green;

            }

        }

        public void GetReservations()
        {
            int dayOfWeek; 
            //SHOW ALL DATA WHEN PAGE LOADS
            dsWashingRoom = dbMethods.ShowData("WashroomReservations");

            DataTable dtReservation = dsWashingRoom.Tables[0];
            foreach (DataRow row in dtReservation.Rows)
            {
                DateTime date_time = (DateTime)row["DateOfRes"]; //MessageBox.Show("Avem" + date_time);

                int time = date_time.Hour; //MessageBox.Show("Avem" + time);
                if (date_time.DayOfWeek == 0)
                    dayOfWeek = (int)date_time.DayOfWeek;   //MessageBox.Show(" day week = " + dayOfWeek);//coloana 
                else
                {
                    dayOfWeek = 7 - (int)date_time.DayOfWeek;
                }
                int floor = Convert.ToInt32(row["Floor"])-1; //MessageBox.Show("Avem" + floor);
                int timeFINAL = (20 - time) / 2; //MessageBox.Show("Avem" + timeFINAL);
                int numarP = 49 * floor + timeFINAL * 7 + dayOfWeek;
                pictureBoxList.ElementAt(numarP).Image = red;
                

            }



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on tabPage2!");

        }


        private void Refr_button_Click(object sender, EventArgs e)
        {

            foreach (TabPage tabPage in WashM_tabControl.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is PictureBox)
                    {
                        pictureBoxList.Add((PictureBox)control);
                    }
                }
            }

            for (int i = 0; i < 245; i++)
            {
                this.pictureBoxList[i].Image = green;

            }

            GetReservations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dayOfWeek = 0;
            String selection = comboBox2.SelectedItem.ToString();
            switch (selection)
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

            int floor = int.Parse(SearchFilters_ComboBox.SelectedItem.ToString());
            //Add the payment
            dbMethods.AddWashReservation(this.roomID, reservationDateTime, time, floor);

            
        }



    }
}