using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using parque_Data_Layer;

namespace parque_Business_Layer
{
    public class claseEncriptado_Business
    {
        private bool saveUser(string user, string password)
        {
            bool isSaved = false;
            byte[] salt = ClaseEncriptadoData.GenerateSalt();
            var hashedPassword = ClaseEncriptadoData.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), salt);

            var connectionString = ConfigurationManager.ConnectionStrings["DemoCredentials"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string saveUser = "INSERT into users (username,salt,pass) VALUES (@username,@salt,@pass)";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = saveUser;
                    command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = user;
                    command.Parameters.Add("@salt", SqlDbType.VarBinary).Value = salt;
                    command.Parameters.Add("@pass", SqlDbType.VarBinary).Value = hashedPassword;

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        if (recordsAffected > 0)
                            isSaved = true;

                    }
                    catch (SqlException ex)
                    {
                        //lblResultado.Text = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return isSaved;
        }

    }
}
