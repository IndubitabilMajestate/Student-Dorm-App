using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DbMethods
    {
        public void AddToDb(string table)
        {
            
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\iiprj.mdf;Integrated Security=True";
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
                    string addquery = "INSERT INTO PitchReservations (IdReservation, RoomNumber, DateOfRes) " +
                        "VALUES (@IdReservation, @RoomNumber, @DateOfRes)";
                    SqlCommand addcmd = new SqlCommand(addquery, myCon);
                    addcmd.Parameters.AddWithValue("@IdReservation", );
                    addcmd.Parameters.AddWithValue("@RoomNumber", );
                    addcmd.Parameters.AddWithValue("@DateOfRes", );


                    addcmd.ExecuteNonQuery();
                    break;

            }
            */


        }

        public void ShowData(string table)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\iiprj.mdf;Integrated Security=True";
            myCon.Open();

            switch (table)
            {
                case "Students":
                    DataSet dsStud = new DataSet();
                    SqlDataAdapter daStud = new SqlDataAdapter("SELECT * FROM Students", myCon);
                    daStud.Fill(dsStud, "Students");
                   
                    foreach (DataRow dr in dsStud.Tables["Students"].Rows)
                    {
                        String item = dr.ItemArray.GetValue(1).ToString();
                    }
                    break;
            }
        }
    }
}
