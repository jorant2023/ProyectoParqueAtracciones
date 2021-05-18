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
using parque_Entity_Layer;


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
                    command.Parameters.Add("@salt", SqlDbType.VarBinary).Value = salt;
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
        public bool isValidPassword(string username, string password)
        {
            claseUsuario_Entity user = getUserFromDB(username);
            bool isValid = false;

            if (!string.IsNullOrEmpty(user.usuario))
            {
                byte[] hashedPassword = ClaseEncriptadoData.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), user.salt);

                if (hashedPassword.SequenceEqual(user.clave))
                    isValid = true;
            }

            return isValid;

        }

        private claseUsuario_Entity getUserFromDB(string username)
        {
            claseUsuario_Entity user = new claseUsuario_Entity();

            var connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string saltSaved = "spSeleccionarUsuarioDesdeUsername";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = saltSaved;
                    command.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = username;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader oReader = command.ExecuteReader())
                        {
                            if (oReader.Read())
                            {
                                user.usuario = oReader["usuario"].ToString();
                                user.salt = (byte[])oReader["salt"];
                                user.clave = (byte[])oReader["clave"];
                                user.id_persona = (int)oReader["id_persona"];
                                user.id_rol = (int)oReader["id_rol"];
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        string message = "" + ex;
                        MessageBox.Show(message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return user;
        }

        public DataTable listarUsuariosBasico()
        {
            DataTable tablaListar = new DataTable();
            var connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string procedure = "spSeleccionarTodosUsuariosBasico";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = procedure;
                    
                    try
                    {
                        connection.Open();
                        using (SqlDataReader oReader = command.ExecuteReader())
                        {
                            tablaListar.Load(oReader);
                           
                        }
                    }
                    catch (SqlException ex)
                    {
                        string message = "" + ex;
                        MessageBox.Show(message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return tablaListar;
        }

    }
}
