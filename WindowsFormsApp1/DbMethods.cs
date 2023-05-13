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
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public class DbMethods
    {
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Razvan\Documents\Facultate\Industrial Informatics\Student-Dorm-App\WindowsFormsApp1\iiprj.mdf;Integrated Security=True";


        public void AddToDb(string table)
        {
            SqlConnection myCon = new SqlConnection();

            myCon.ConnectionString = ConnectionString;
            myCon.Open();
            AdminAddStudent adminAddStudent = new AdminAddStudent();


            switch (table)
            {

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


                    addcmd.Parameters.AddWithValue("@IDCard", 0);
                    addcmd.Parameters.AddWithValue("@ProfilePic", 0);
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

        public DataSet ShowData(string table)
        {
            AdminRents rents = new AdminRents();
            List<string> studentData = new List<string>();
            using (SqlConnection myCon = new SqlConnection(ConnectionString))

            {
                switch (table)
                {
                    case "Students":
                        DataSet dsStud = new DataSet();
                        SqlDataAdapter daStud = new SqlDataAdapter("SELECT * FROM Students", myCon);
                        daStud.Fill(dsStud, "Students");
                        /*
                        foreach (DataRow dr in dsStud.Tables["Students"].Rows)
                        {
                            string data = String.Join(",", dr.ItemArray.Select(x => x.ToString()));
                            studentData.Add(data);
                        }
                        */
                        myCon.Close();
                        return dsStud;


                        break;

                    case "Students_Payments":

                        DataSet dsPayments = new DataSet();
                        SqlDataAdapter daPayments = new SqlDataAdapter("SELECT * FROM Students_Payments", myCon);
                        daPayments.Fill(dsPayments, "Students_Payments");

                        myCon.Close();
                        return dsPayments;

                        break;
                    case "Students_Payments_Rent":
                        DataSet dsPayments1 = new DataSet();
                        SqlDataAdapter daPayments1 = new SqlDataAdapter("SELECT * FROM Students_Payments WHERE PaymentType = 'Rent'", myCon);
                        daPayments1.Fill(dsPayments1, "Students_Payments");


                        myCon.Close();
                        return dsPayments1;

                        break;

                    case "Students_Payments_Penalty":
                        DataSet dsPayments2 = new DataSet();
                        SqlDataAdapter daPayments2 = new SqlDataAdapter("SELECT * FROM Students_Payments WHERE PaymentType = 'Penalty'", myCon);
                        daPayments2.Fill(dsPayments2, "Students_Payments");

                        myCon.Close();
                        return dsPayments2;

                        break;

                    case "Students_Payments_Pitch":
                        DataSet dsPayments3 = new DataSet();
                        SqlDataAdapter daPayments3 = new SqlDataAdapter("SELECT * FROM Students_Payments WHERE PaymentType = 'Pitch'", myCon);
                        daPayments3.Fill(dsPayments3, "Students_Payments");

                        myCon.Close();
                        return dsPayments3;

                        break;

                    case "Students_Payments_Pool":
                        DataSet dsPayments4 = new DataSet();
                        SqlDataAdapter daPayments4 = new SqlDataAdapter("SELECT * FROM Students_Payments WHERE PaymentType = 'Pool'", myCon);
                        daPayments4.Fill(dsPayments4, "Students_Payments");

                        myCon.Close();
                        return dsPayments4;

                        break;




                    default:
                        return null;

                }

            }
        }

        public DataSet SearchPaymentsByMonth(int month)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM Students_Payments WHERE MONTH(PaymentDate) = @SearchMonth";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchMonth", month);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "Students_Payments");

                    return ds;

                }
            }

        }

        public DataSet SearchPaymentsByStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM Students_Payments WHERE Student_Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "Students_Payments");

                    return ds;

                }
            }

        }

        public DataSet SearchPaymentsByIdMonth(int id, int month)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM Students_Payments WHERE Student_Id = @id AND MONTH(PaymentDate) = @SearchMonth";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@SearchMonth", month);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "Students_Payments");

                    return ds;

                }
            }

        }

        public DataSet GetbyUser(string username, string table)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = table == "Admin_Login"? "SELECT * FROM Admin_Login WHERE Username = @username":"SELECT * FROM Students WHERE Username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                }
                return ds;
            }

        }

        public DataSet GetStudbyId(int id)
        {
            
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query ="SELECT * FROM Students WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                }
                return ds;
            }

        }

        public DataSet GetStudbyRoom(int room,int id)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM Students WHERE Room = @room AND NOT Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@room", room);
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                }
                return ds;
            }

        }

        public void AddComplaint(DataRow dataRow)
        {
           using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Complaints (Id, Title, Content, RoomId, Solved) " +
                                "VALUES (@Id, @Title, @Content, @RoomId, @Solved)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", dataRow["Id"]);
                    command.Parameters.AddWithValue("@Title", dataRow["Title"]);
                    command.Parameters.AddWithValue("@Content", dataRow["Content"]);
                    command.Parameters.AddWithValue("@RoomId", dataRow["RoomId"]);
                    command.Parameters.AddWithValue("@Solved", dataRow["Solved"]);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}