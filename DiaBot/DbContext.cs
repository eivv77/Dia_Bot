using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaBot
{
    public class DbContext
    {
        /*Connection_String con = new Connection_String();

        public void RegisterUser(string username)
        {
            using (SqlConnection connection = new SqlConnection(con.Connection_string))
            {
                connection.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = connection;
                comm.CommandText = "INSERT INTO Users VALUES(@username)";
                comm.Parameters.AddWithValue("@username", username);
                comm.ExecuteNonQuery();
                connection.Close();
            }
        }*/
    }
}
