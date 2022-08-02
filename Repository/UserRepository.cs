using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository
    {
        public User GetUserByUsernamePassword(string username, string password)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "test";
            cs.DataSource = "(localdb)\\MSSQLLocalDB";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select id, username, password from users where username = @username and password=@password";
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                reader = cmd.ExecuteReader();


                if (!reader.Read()) return null;

                return new User() //Int32.Parse(reader[0].ToString());
                {
                    Id = Int32.Parse(reader["Id"].ToString()),
                    Username = reader["username"].ToString(),
                    Password = reader["password"].ToString()
                };

            }
            catch (Exception e)
            {
                throw e;

            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();

            }

        }
        public User GetUserById(int Id)
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();
            cs.InitialCatalog = "test";
            cs.DataSource = "(localdb)\\MSSQLLocalDB";
            cs.IntegratedSecurity = true;

            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = cs.ConnectionString;
            IDataReader reader = null;
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sql;
                cmd.CommandText = "select id, username, password from users where usernameid = @id";
                cmd.Parameters.AddWithValue("id", Id);
                reader = cmd.ExecuteReader();
                if (!reader.Read()) return null;

                return new User() //Int32.Parse(reader[0].ToString());
                {
                    Id = Int32.Parse(reader["Id"].ToString()),
                    Username = reader["username"].ToString(),
                    Password = reader["password"].ToString()
                };

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (sql != null)
                    sql.Close();

            }
        }
    }
}
