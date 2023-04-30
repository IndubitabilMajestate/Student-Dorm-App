using System;
using System.Collections.Generic;
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

            /*
            switch (table) {
            
                case "Students":
                    string addquery = "INSERT INTO Students (Id, LastName, FirstName, Faculty_Year, Faculty, PCD, Room, Username, Password, Email, IDCard, ProfilePic) " +
                        "VALUES (@Id, @LastName, @FirstName, @Faculty_Year, @Faculty, @PCD, @Room, @Username, @Password, @Email, @IDCard, @ProfilePic)";
                    SqlCommand addcmd = new SqlCommand(addquery, myCon);
                    addcmd.Parameters.AddWithValue("@Id", );
                    addcmd.Parameters.AddWithValue("@LastName", );
                    addcmd.Parameters.AddWithValue("@FirstName", );
                    addcmd.Parameters.AddWithValue("@Faculty_Year", );
                    addcmd.Parameters.AddWithValue("@Faculty", );
                    addcmd.Parameters.AddWithValue("@PCD", );
                    addcmd.Parameters.AddWithValue("@Room", );
                    addcmd.Parameters.AddWithValue("@Username", );
                    addcmd.Parameters.AddWithValue("@Password", );
                    addcmd.Parameters.AddWithValue("@Email", );
                    addcmd.Parameters.AddWithValue("@IDCard", );
                    addcmd.Parameters.AddWithValue("@ProfilePic", );
                    addcmd.ExecuteNonQuery();
                    
                    break;

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

            }
            */

            myCon.Close();
        }

        public string[] ShowData(string table)
        {
            List<string> studentData = new List<string>();
            myCon.ConnectionString = ConnectionString;
            myCon.Open();

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
                    break;
            }
            myCon.Close();
            //string message = String.Join("\n", studentData);
            //MessageBox.Show(message);
            return studentData.ToArray();
           
        }
    }
}
