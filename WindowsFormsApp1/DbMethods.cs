
using StudentDormApp;
using System;
using System.Collections;
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
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Noemi\Documents\GitHub\Student-Dorm-App\WindowsFormsApp1\iiprj.mdf;Integrated Security = True";

        public void AddToDb(string table)
        {
            SqlConnection myCon = new SqlConnection();

            myCon.ConnectionString = ConnectionString;
            myCon.Open();
            AdminAddStudent adminAddStudent = new AdminAddStudent();
            StudentPay studentPay = new StudentPay(1);


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

                case "Students_Payments_Rent_Pen":
                    string addquery1 = "INSERT INTO Students_Payments (Student_Id, Paid, PaymentDate, PaymentType, SumToPay) " +
                        "VALUES (@Student_Id, @Paid, @PaymentDate, @PaymentType, @SumToPay)";
                    SqlCommand addcmd1 = new SqlCommand(addquery1, myCon);

                    addcmd1.Parameters.AddWithValue("@Student_Id", studentPay.textBox2.Text);
                    addcmd1.Parameters.AddWithValue("@Paid", 1);
                    addcmd1.Parameters.AddWithValue("@PaymentDate", System.DateTime.Now);
                    addcmd1.Parameters.AddWithValue("@PaymentType", studentPay.SearchFilters_ComboBox.SelectedItem.ToString());
                    addcmd1.Parameters.AddWithValue("@SumToPay", studentPay.Sum_Box1.Text);


                    addcmd1.ExecuteNonQuery();

                    break;


                case "Students_Payments_Facilities":
                    string addquery2 = "INSERT INTO Students_Payments (Student_Id, Paid, PaymentDate, PaymentType, SumToPay) " +
                        "VALUES (@Student_Id, @Paid, @PaymentDate, @PaymentType, @SumToPay)";
                    SqlCommand addcmd2 = new SqlCommand(addquery2, myCon);

                    addcmd2.Parameters.AddWithValue("@Student_Id", studentPay.textBox2.Text);
                    addcmd2.Parameters.AddWithValue("@Paid", 1);
                    addcmd2.Parameters.AddWithValue("@PaymentDate", System.DateTime.Now);
                    addcmd2.Parameters.AddWithValue("@PaymentType", studentPay.Facilities_ComboBox.SelectedItem.ToString());
                    addcmd2.Parameters.AddWithValue("@SumToPay", studentPay.Sum_Box2.Text);


                    addcmd2.ExecuteNonQuery();

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


        public void AddPayments(int id, String type,  int sum)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = ConnectionString;
            myCon.Open();

            try
            {
                string addquery1 = "INSERT INTO Students_Payments (Student_Id, Paid, PaymentDate, PaymentType, SumToPay) " 
                    + " VALUES (@Student_Id, @Paid, @PaymentDate, @PaymentType, @SumToPay) ";
                SqlCommand addcmd1 = new SqlCommand(addquery1, myCon);

                addcmd1.Parameters.AddWithValue("@Student_Id", id);
                addcmd1.Parameters.AddWithValue("@Paid", true);
                addcmd1.Parameters.AddWithValue("@PaymentDate", System.DateTime.Now);
                addcmd1.Parameters.AddWithValue("@PaymentType", type);
                addcmd1.Parameters.AddWithValue("@SumToPay", sum);

                addcmd1.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                myCon.Close();
            }
        }


        public void AddPitchReservation(int id, DateTime datetime, DateTime time)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = ConnectionString;
            myCon.Open();

            try
            {
                string addquery = "INSERT INTO PitchReservations (StudentId, DateOfRes, TimeOfRes) " +
                   "VALUES (@studentId, @dateOfRes, @timeOfRes) ";

                using (SqlCommand command = new SqlCommand(addquery, myCon))
                {
                    command.Parameters.AddWithValue("@studentId",id);
                    command.Parameters.AddWithValue("@dateOfRes", datetime);
                    command.Parameters.AddWithValue("@timeOfRes", time);
            
                    int reservationId = command.ExecuteNonQuery();
                    
                }
                MessageBox.Show("Payment done");
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Time slot already taken. Choose another one!");
            }
            finally
            {
                myCon.Close();
                
                    
            }
        }

        public void AddPoolReservation(int id, DateTime datetime)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = ConnectionString;
            myCon.Open();

            try
            {
                string addquery = "INSERT INTO PoolReservations (StudentId, DateOfRes)" +
                   "VALUES (@studentId, @dateOfRes) ";

                using (SqlCommand command = new SqlCommand(addquery, myCon))
                {
                    command.Parameters.AddWithValue("@studentId", id);
                    command.Parameters.AddWithValue("@dateOfRes", datetime);

                    int reservationId = command.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                myCon.Close();
            }
        }

        public void AddWashReservation(int roomnr, DateTime datetime, DateTime time, int floor)
        {
            SqlConnection myCon = new SqlConnection();
            myCon.ConnectionString = ConnectionString;
            myCon.Open();

            try
            {
                string addquery = "INSERT INTO WashroomReservations (RoomNumber, DateOfRes, TimeOfRes, Floor) " +
                   "VALUES (@room, @dateOfRes, @timeOfRes, @floor) ";

                using (SqlCommand command = new SqlCommand(addquery, myCon))
                {
                    command.Parameters.AddWithValue("@room", roomnr);
                    command.Parameters.AddWithValue("@dateOfRes", datetime);
                    command.Parameters.AddWithValue("@timeOfRes", time);
                    command.Parameters.AddWithValue("@floor", floor);

                    int reservationId = command.ExecuteNonQuery();

                }
                MessageBox.Show("Reservation done");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Time slot already taken. Choose another one!");
            }
            finally
            {
                myCon.Close();
            }
        }
        public DataSet SearchPoolResByStudent(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM PoolReservations WHERE StudentId = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "PoolReservations");

                    return ds;

                }
            }

        }

        public DataSet SearchRPByStudentId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM Students_Payments WHERE Student_Id = @id AND (PaymentType = 'Rent' OR PaymentType = 'Penalty')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "Students_Payments");

                    return ds;

                }
            }

        }

        public DataSet SearchPoolPayByStudentId(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                string query = "SELECT * FROM Students_Payments WHERE Student_Id = @id AND (PaymentType = 'Swimming Pool entry')";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds, "Students_Payments");

                    return ds;

                }
            }

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

                    case "Students_Payments_RP":
                        DataSet dsPayments5 = new DataSet();
                        SqlDataAdapter daPayments5 = new SqlDataAdapter("SELECT * FROM Students_Payments WHERE PaymentType = 'Rent' OR PaymentType = 'Penalty'", myCon);
                        daPayments5.Fill(dsPayments5, "Students_Payments");

                        myCon.Close();
                        return dsPayments5;

                        break;


                    case "Students_Payments_PitchPool":
                        DataSet dsPayments6 = new DataSet();
                        SqlDataAdapter daPayments6 = new SqlDataAdapter("SELECT * FROM Students_Payments WHERE PaymentType = 'Pool' OR PaymentType = 'Pitch'", myCon);
                        daPayments6.Fill(dsPayments6, "Students_Payments");

                        myCon.Close();
                        return dsPayments6;

                        break;

                    case "WashroomReservations":
                        DataSet dsPayments7 = new DataSet();
                        SqlDataAdapter daPayments7 = new SqlDataAdapter("SELECT * FROM WashroomReservations", myCon);
                        daPayments7.Fill(dsPayments7, "WashroomReservations");

                        myCon.Close();
                        return dsPayments7;

                        break;

                    case "PitchReservations":
                        DataSet dsPayments8 = new DataSet();
                        SqlDataAdapter daPayments8 = new SqlDataAdapter("SELECT * FROM PitchReservations", myCon);
                        daPayments8.Fill(dsPayments8, "PitchReservations");

                        myCon.Close();
                        return dsPayments8;

                        break;

                    default:
                        return null;



                }

            }
        }

        



    }
}