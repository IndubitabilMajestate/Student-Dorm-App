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

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminPage_COP_btn_Click(object sender, EventArgs e)
        {
            AdminOtherPays adminOtherPays = new AdminOtherPays();
            adminOtherPays.Show();
        }

        private void AdminPage_R_btn_Click(object sender, EventArgs e)
        {
            AdminRents rents = new AdminRents();
            rents.Show();
        }

        private void AdminPage_RP_btn_Click(object sender, EventArgs e)
        {

        }

        private void AdminPage_MR_btn_Click(object sender, EventArgs e)
        {
            RoomManagementPage roomManagementPage = new RoomManagementPage();
            roomManagementPage.Show();
        }
    }
}
