/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kuliah_Manager
{
    class ClassDAL
    {
        //Create a Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["Kuliah_Manager.Properties.Settings.connstrng"].ConnectionString;


        #region SELECT data from database
        public DataTable Select()
        {
            //Create an Object to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a DataTable to Hold the Data from Database
            DataTable dt = new DataTable();

            try
            {
                // WRite SQL Qery to Get Data from Database
                String sql = "SELECT * FROM ClassTbl";

                //Create SQL Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Sql Data Adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                //Transfer Data from SqlData Adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region Insert Data into Database for Day Menu Module
        public bool Insert(ClassBLL u)
        {
            //Create a boolean variable and set its default value to false
            bool isSuccess = false;

            //Create an Object of SqlConnection to connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a String Variable to Store the INSERT Query
                String sql = "INSERT INTO ClassTbl(Matkul, LinkMeeting, LinkPresensi, LinkDrive, Hari, Waktu) VALUES (@Matkul, @LinkMeeting, @LinkPresensi, @LinkDrive, @Hari, @Waktu)";

                //Create a SQL Command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create the Parameter to pass get the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@Matkul", u.ClassName);
                cmd.Parameters.AddWithValue("@LinkMeeting", u.MeetingLink);
                cmd.Parameters.AddWithValue("@LinkPresensi", u.AttendanceLink);
                cmd.Parameters.AddWithValue("@LinkDrive", u.DriveLink);
                cmd.Parameters.AddWithValue("@Hari", u.Day);
                cmd.Parameters.AddWithValue("@Waktu", u.Time);

                //Open Database Connection
                conn.Open();

                //Create an Integer VAriable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //The value of rows will be greater than 0 if the query is executed successfully
                //Else it'll be 0

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //DIsplay Error Message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region UPDATE data in database (User Module)
        public bool Update(ClassBLL u)
        {
            //Create a Boolean variable and set its default value to false
            bool isSuccess = false;

            //Create an Object for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a string variable to hold the sql query
                string sql = "UPDATE ClassTbl SET Matkul=@Matkul, LinkMeeting=@LinkMeeting, LinkPresensi=@LinkPresensi, LinkDrive=@LinkDrive, Hari=@Hari, Waktu=@Waktu";

                //Create Sql Command to execute query and also pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Now Pass the values to SQL Query
                cmd.Parameters.AddWithValue("@Matkul", u.ClassName);
                cmd.Parameters.AddWithValue("@LinkMeeting", u.MeetingLink);
                cmd.Parameters.AddWithValue("@LinkPresensi", u.AttendanceLink);
                cmd.Parameters.AddWithValue("@LinkDrive", u.DriveLink);
                cmd.Parameters.AddWithValue("@Hari", u.Day); ;
                cmd.Parameters.AddWithValue("@Waktu", u.Time);

                //open Database Connection
                conn.Open();

                //Create an integer variable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then the value of rows will be greater than 0
                //else it'll be 0

                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;

                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display error message if there's any exceptional error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Delete Data from Database (User Module)
        public bool Delete(ClassBLL u)
        {
            //Create a boolean variable and set its default value to false
            bool isSuccess = false;

            //Create an object for SqlConnection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a string variable to hold the sql query to delete data
                String sql = "DELETE FROM ClassTbl WHERE Matkul=@Matkul";

                //Create Sql Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the value thorugh parameters
                cmd.Parameters.AddWithValue("@Matkul", u.ClassName);

                //Open the DAtabase Connection
                conn.Open();

                //Create an integer variable to hold the value after query is executed
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed Successfully then the value of rows will be greater than zero(0)
                //Else it'll be zero(0)

                if (rows > 0)
                {
                    //Query executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Excetionl errors
                MessageBox.Show(ex.Message);
            }
            finally
            {

                //CLose Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
    }
}
*/