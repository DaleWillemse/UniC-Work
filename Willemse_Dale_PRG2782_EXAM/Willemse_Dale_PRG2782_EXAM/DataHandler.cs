using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Willemse_Dale_PRG2782_EXAM
{
    internal class DataHandler
    {
        private string con = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\MetaPlatformsDB.mdf; Integrated Security = True";
        private SqlConnection connection;

        public DataHandler() { }

        public void OpenConnection()
        {
            connection = new SqlConnection(con);
            connection.Open();
        }

        public void AddUser(string name, string surname,string email,string password, string gender, string birthday)
        {
            try
            {
                OpenConnection();
                string query = $"INSERT INTO tblRegistration (Name, Surname, Email, Password, Gender, Birthday) VALUES ('{name}', '{surname}', '{email}', '{password}', '{gender}', '{birthday}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("User successfully added.");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();

            }
        }

        public DataTable DisplayUsers(string query) // takes in a query as a parameter sent by the button click to display all users. 
        {

            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connection.Close();

            return dt;

        }

        public void DeleteUser(String query) // takes in a query as a parameter sent by the button click to delete a user. 
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
