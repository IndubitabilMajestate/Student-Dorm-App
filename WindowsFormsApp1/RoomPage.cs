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
    public partial class RoomPage : Form
    {
        private int curr_id;
        private DbMethods dbMethods;
        public RoomPage(int id)
        {
            this.curr_id = id;
            dbMethods = new DbMethods();
            string[] data =
            {
                dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["Room"].ToString(),
                dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["LastName"].ToString(),
                dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["FirstName"].ToString(),
                dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["Email"].ToString(),
                (bool)dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["PCD"] ? "DA":"NU",
                dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["Faculty"].ToString(),
                dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["Faculty_Year"].ToString(),
            };
            DataSet ds = new DataSet();
            ds = dbMethods.GetStudbyRoom(int.Parse(data[0]), curr_id);
            Student student2 = new Student(0, "", "", "", false, "", 0);
            Student student3 = new Student(0, "", "", "", false, "", 0);
            Student student4 = new Student(0, "", "", "", false, "", 0);
            if (ds.Tables[0].Rows.Count != 0)
            {
                student2 = ConvertStudData(ds.Tables[0].Rows[0]) as Student;
                try
                {
                    student3 = ConvertStudData(ds.Tables[0].Rows[1]) as Student;
                }
                catch {
                }
                try
                {
                    student4 = ConvertStudData(ds.Tables[0].Rows[2]) as Student;
                }
                catch {
                }
            }
            Student[] studs = { student2, student3, student4 };
            InitializeComponent();
            RoomID_lbl.Text     = "Room " + data[0];
            Nume1.Text          =   data[1];
            Prenume1.Text       =   data[2];
            Contact1.Text       =   data[3];
            Facultate1.Text     =   data[4];
            An1.Text            =   data[5];
            PCD1.Text           =   data[6];


            Nume2.Text          = studs[0].nume;
            Prenume2.Text       = studs[0].prenume;
            Contact2.Text       = studs[0].contact;
            Facultate2.Text     = studs[0].fac;
            An2.Text            = studs[0].an.ToString();
            PCD2.Text           = studs[0].PCD ? "DA" : "NU";

            Nume3.Text          = studs[1].nume;
            Prenume3.Text       = studs[1].prenume;
            Contact3.Text       = studs[1].contact;
            Facultate3.Text     = studs[1].fac;
            An3.Text            = studs[1].an.ToString();
            PCD3.Text           = studs[1].PCD ? "DA" : "NU";

            Nume4.Text          = studs[2].nume;
            Prenume4.Text       = studs[2].prenume;
            Contact4.Text       = studs[2].contact;
            Facultate4.Text     = studs[2].fac;
            An4.Text            = studs[2].an.ToString();
            PCD4.Text           = studs[2].PCD ? "DA" : "NU";

        }


        private Student ConvertStudData(DataRow dr)
        {
            string[] data =
            {
                dr["Id"].ToString(),
                dr["LastName"].ToString(),
                dr["FirstName"].ToString(),
                dr["Email"].ToString(),
                dr["Faculty"].ToString(),
                dr["Faculty_Year"].ToString(),
            };
            bool pcd = (bool)dr["PCD"];
            return new Student(int.Parse(data[0]), data[1], data[2], data[3], pcd, data[4], int.Parse(data[5]));
        }

        private void RoomPage_SD_btn_Click(object sender, EventArgs e)
        {
            if(RoomPage_PW_tb.Text == dbMethods.GetStudbyId(curr_id).Tables[0].Rows[0]["Password"].ToString())
            {
                MessageBox.Show("Documente");
            }
        }
    }
    class Student
    {
        public int id;
        public string nume;
        public string prenume;
        public string contact;
        public bool PCD;
        public string fac;
        public int an;
        public Image image;

        public Student(int id, string nume, string prenume, string contact, bool pCD, string fac, int an)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.contact = contact;
            PCD = pCD;
            this.fac = fac;
            this.an = an;
        }
    }
}
