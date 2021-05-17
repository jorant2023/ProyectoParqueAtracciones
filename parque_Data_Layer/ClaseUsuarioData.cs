using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace parque_Data_Layer
{
    public class ClaseUsuarioData
    {
        public bool insertarUsuario(int id_persona, int id_rol, string usuario, string clave)
        {
            bool isSaved = false;
            byte[] salt = ClaseEncriptadoData.GenerateSalt();
            var hashedPassword = ClaseEncriptadoData.HashPasswordWithSalt(Encoding.UTF8.GetBytes(clave), salt);
            var connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //string saveUser = "INSERT INTO dbo.tabla_usuarios (id_persona, id_rol, usuario, clave) VALUES (@idPer, @idRol, @user, @clave)";
                //string saveUser = "spAgregaUsuario(@idPer, @idRol, @user, @clave)";
                string saveUser = "spAgregaUsuario";




                using (SqlCommand command = new SqlCommand())
                {

                    
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = saveUser;
                    command.Parameters.Add("@idPer", SqlDbType.Int).Value = id_persona;
                    command.Parameters.Add("@idRol", SqlDbType.Int).Value = id_rol;
                    command.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = usuario;
                    command.Parameters.Add("@clave", SqlDbType.VarBinary).Value = hashedPassword;
                    command.Parameters.Add("@msg", SqlDbType.VarChar, 50).Value = "";


                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        if (recordsAffected > 0)
                            isSaved = true;

                        string message = "Cambios correctamente realizados";
                        MessageBox.Show(message);

                    }
                    catch (SqlException ex)
                    {

                        string message = ""+ex;
                        MessageBox.Show(message);
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
