using StudentDormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DbMethods
    { 
        private string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\iiprj.mdf;Integrated Security=True";
        SqlConnection myCon = new SqlConnection();
        public void AddToDb(string table)
        {
            myCon.ConnectionString = ConnectionString;
            myCon.Open();
            AdminAddStudent adminAddStudent = new AdminAddStudent();


            switch (table) {

                case "Students":
                    string addquery = "INSERT INTO Students (LastName, FirstName, Faculty_Year, Faculty, PCD, Room, Username, Password, Email, IDCard, ProfilePic) " +
                        "VALUES (@LastName, @FirstName, @Faculty_Year, @Faculty, @PCD, @Room, @Username, @Password, @Email, @IDCard, @ProfilePic)";
                    SqlCommand addcmd = new SqlCommand(addquery, myCon);

                    addcmd.Parameters.AddWithValue("@LastName", adminAddStudent.tb_LastName.Text);
                    addcmd.Parameters.AddWithValue("@FirstName", adminAddStudent.tb_FirstName.Text);
                    addcmd.Parameters.AddWithValue("@Faculty_Year", adminAddStudent.tb_FacYear.Text);
                    addcmd.Parameters.AddWithValue("@Faculty", adminAddStudent.tb_Fac.Text);
                    addcmd.Parameters.AddWithValue("@PCD", adminAddStudent.cb_PCD.Checked);
                    addcmd.Parameters.AddWithValue("@Room", adminAddStudent.tb_RoomAddStud.Text);
                    addcmd.Parameters.AddWithValue("@Username", adminAddStudent.tb_UsernameAdd.Text);
                    addcmd.Parameters.AddWithValue("@Password", adminAddStudent.tb_PasswordAdd.Text);
                    addcmd.Parameters.AddWithValue("@Email", adminAddStudent.tb_EmailAdd.Text);


                    //addcmd.Parameters.AddWithValue("@IDCard", );
                    //addcmd.Parameters.AddWithValue("@ProfilePic", );
                    addcmd.ExecuteNonQuery();

                    break;
                    /*
                        case "Students_Rooms":
                            string addquery = "INSERT INTO Students_Rooms (Room, Student1_Id, Student2_Id, Student3_Id, Student4_Id) " +
                                "VALUES (@Room, @Student1_Id, @Student2_Id, @Student3_Id, @Student4_Id)";
                            SqlCommand addcmd = new SqlCommand(addquery, myCon);
                            addcmd.Parameters.AddWithValue("@Room", );
                            addcmd.Parameters.AddWithValue("@Student1_Id", );
                            addcmd.Parameters.AddWithValue("@Student2_Id", );
                            addcmd.Parameters.AddWithValue("@Student3_Id", );
                            addcmd.Parameters.AddWithValue("@Student4_Id", );

                            addcmd.ExecuteNonQuery();

                            break;

                        case "PitchReservations":
                            string addquery = "INSERT INTO PitchReservations (IdReservation, StudentId, DateOfRes) " +
                                "VALUES (@IdReservation, @StudentId, @DateOfRes)";
                            SqlCommand addcmd = new SqlCommand(addquery, myCon);
                            addcmd.Parameters.AddWithValue("@IdReservation", );
                            addcmd.Parameters.AddWithValue("@StudentId", );
                            addcmd.Parameters.AddWithValue("@DateOfRes", );


                            addcmd.ExecuteNonQuery();
                            break;

                        case "PoolReservations":
                            string addquery = "INSERT INTO PoolReservations (IdReservation, StudentId, DateOfRes) " +
                                "VALUES (@IdReservation, @StudentId, @DateOfRes)";
                            SqlCommand addcmd = new SqlCommand(addquery, myCon);
                            addcmd.Parameters.AddWithValue("@IdReservation", );
                            addcmd.Parameters.AddWithValue("@StudentId", );
                            addcmd.Parameters.AddWithValue("@DateOfRes", );


                            addcmd.ExecuteNonQuery();
                            break;

                        case "WashroomReservations":
                    //aici am pus identity si trebe sa sterg addu de id, teoretic merge
                            string addquery = "INSERT INTO WashroomReservations (RoomNumber, DateOfRes, TimeOfRes, Floor) " +
                                "VALUES (@RoomNumber, @DateOfRes, @Floor)";
                            SqlCommand addcmd = new SqlCommand(addquery, myCon);      
                            addcmd.Parameters.AddWithValue("@RoomNumber", );
                            addcmd.Parameters.AddWithValue("@DateOfRes, dtpicker_DateWash.Value.ToShortDateString);
                            addcmd.Parameters.AddWithValue("@TimeOfRes", dtpicker_TimeWash.Value.ToShortTimeString);
                            addcmd.Parameters.AddWithValue("@Floor", tbFloorWashroom.Text);


                            addcmd.ExecuteNonQuery();
                            break;

                    
                    */
            }
            myCon.Close();
        }

        public string[] ShowData(string table)
        {
            List<string> studentData = new List<string>();
            myCon.ConnectionString = ConnectionString;
            myCon.Open();
            Rents rents = new Rents();
            switch (table)
            {
                case "Students":
                    DataSet dsStud = new DataSet();
                    SqlDataAdapter daStud = new SqlDataAdapter("SELECT * FROM Students", myCon);
                    daStud.Fill(dsStud, "Students");

                    foreach (DataRow dr in dsStud.Tables["Students"].Rows)
                    {
                        string data = String.Join(",", dr.ItemArray.Select(x => x.ToString()));
                        studentData.Add(data);
                    }
                    return studentData.ToArray();

                    break;

                case "Students_Payments_Rent":
                    DataSet dsPayments = new DataSet();
                    SqlDataAdapter daPayments = new SqlDataAdapter("SELECT * FROM Students_Payments WHERE PaymentType = 'Rent'", myCon);
                    daPayments.Fill(dsPayments, "Students_Payments");
                    BindingList<string> bindingList = new BindingList<string>();
                    //string blabla = dsPayments.GetXml();
                    //MessageBox.Show(blabla); // asta afiseaza

                    foreach (DataRow row in dsPayments.Tables["Students_Payments"].Rows)
                    {

                        string Student_Id = row["Student_Id"].ToString();
                        string Payment_Id = row["Payment_Id"].ToString();
                        string Paid = row["Paid"].ToString();
                        string PaymentDate = row["PaymentDate"].ToString();
                        string PaymentType = row["PaymentType"].ToString();
                        string SumToPay = row["SumToPay"].ToString();
                        string displayText = string.Format("{0} | {1} | {2} | {3} | {4} | {5} | {6}", Student_Id, Payment_Id, Paid, PaymentDate, PaymentType, SumToPay);
                        bindingList.Add(displayText);
                    }
                    rents.PaymentContent.DataSource = bindingList;

                    break;
            }
            myCon.Close();
            //string message = String.Join("\n", studentData);
            //MessageBox.Show(message);
           
        }
    }
}
