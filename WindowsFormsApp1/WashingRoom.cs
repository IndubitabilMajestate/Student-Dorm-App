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
    public partial class WashingRoom : Form
    {
        public bool[,] seats = new bool[7,7];

        List<PictureBox> pictureBoxList = new List<PictureBox>();

        public WashingRoom()
        {
            InitializeComponent();


            foreach (TabPage tabPage in WashM_tabControl.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    if (control is PictureBox)
                    {
                        pictureBoxList.Add((PictureBox)control);
                    // ((PictureBox)control).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");
                    }
                }
            }


            for (int i = 0; i < 49; i++)
            {
                (pictureBoxList[i]).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void WashingRoom_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked on tabPage2!");
            /*
            textBox1.Text = "sdhhdkhdk";
            for (int i = 0; i < 48; i++)
            {
                (pictureBoxList[i]).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");

            }*/
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            // Do something when the user clicks on tabPage1
            MessageBox.Show("You clicked on tabPage2!");
            /*
            textBox1.Text = "sdhhdkhdk";
            for (int i = 49; i < 97; i++)
            {
                (pictureBoxList[i]).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");

            }*/
        }

        private void Refr_button_Click(object sender, EventArgs e)
        {
            string floor = WashM_tabControl.SelectedTab.ToString();
            textBox1.Text = floor;
            MessageBox.Show(floor);
            switch(floor)
            {
                case "TabPage: {1st floor}":
                    {
                        for (int i = 0; i < 48; i++)
                        {
                            (pictureBoxList[i]).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");

                        }
                        break;
                    }
                case "TabPage: {2nd floor}":
                    for (int i = 49; i < 99; i++)
                    {
                        (pictureBoxList[i]).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");

                    }
                    break;

                case "TabPage: {3rd floor}":
                    for (int i = 100; i < 153; i++)
                    {
                        (pictureBoxList[i]).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");

                    }
                    break;

                case "TabPage: {4th floor}":
                    for (int i = 153; i < 209; i++)
                    {
                        (pictureBoxList[i]).Image = Image.FromFile("C:\\Users\\Noemi\\Documents\\GitHub\\Student-Dorm-App\\WindowsFormsApp1\\green.jpg");

                    }
                    break;

                case "TabPage: {5th floor}":
                break;
            }
        }
    }
}
