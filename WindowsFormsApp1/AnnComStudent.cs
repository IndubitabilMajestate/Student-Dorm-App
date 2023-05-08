using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDormApp
{
    public partial class AnnComStudent : Form
    {
        private int curr_id;
        public AnnComStudent(int id)
        {
            this.curr_id = id;
            InitializeComponent();
        }

        private void AnnComPage_CC_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
