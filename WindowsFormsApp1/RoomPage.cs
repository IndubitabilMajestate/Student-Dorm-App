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
        private Student curr_student;
        public RoomPage(int id)
        {
            this.curr_id = id;
            this.curr_student = new Student(/*TODO get data from DB*/23,"testN","testP","test@mail.com",true,"testF",2);
            Student[] studs = new Student[] { 
                new Student(23,"testN2","testP3","test2@mail.com",false,"testF",3),
                new Student(23,"testN5","testP3","test4@mail.com",false,"testF2",1),
                new Student(23,"testN1","testP2","test4@mail.com",true,"testF2",2) };
            InitializeComponent();
            RoomID_lbl.Text     = "Room " + curr_id.ToString();
            Nume1.Text          = curr_student.nume;
            Prenume1.Text       = curr_student.prenume;
            Contact1.Text       = curr_student.contact;
            Facultate1.Text     = curr_student.fac;
            An1.Text            = curr_student.an.ToString();
            PCD1.Text           = curr_student.PCD ? "DA" : "NU";


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
