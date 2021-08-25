using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using parque_Data_Layer;
using parque_Entity_Layer;

namespace parque_Business_Layer
{
    public class ClaseUsuarioBusiness
    {
        public static bool insertarUsuario(int id_persona, int id_rol, string usuario, string clave)
        {
            ClaseUsuarioData claseUsuarioData = new ClaseUsuarioData();
            return claseUsuarioData.insertarUsuario(id_persona,  id_rol,  usuario,  clave);
        }
        public static bool modificarUsuario(int id_persona, int id_rol, string usuario, string clave)
        {
            ClaseUsuarioData claseUsuarioData = new ClaseUsuarioData();
            return claseUsuarioData.modificarUsuario(id_persona, id_rol, usuario, clave);
        }
        public static bool eliminarUsuario(string usuario)
        {
            ClaseUsuarioData claseUsuarioData = new ClaseUsuarioData();
            return claseUsuarioData.eliminarUsuario(usuario);
        }
        public static bool comprobarPassword(string username, string password)
        {
            ClaseUsuarioData claseUsuarioData = new ClaseUsuarioData();
            return claseUsuarioData.isValidPassword(username, password);
        }

        public static DataTable listarUsuariosBasico()
        {
            ClaseUsuarioData claseUsuarioData = new ClaseUsuarioData();
            return claseUsuarioData.listarUsuariosBasico();
        }
        public static claseUsuario_Entity getUserFromDB(string username)
        {
            ClaseUsuarioData claseUsuarioData = new ClaseUsuarioData();
            return claseUsuarioData.getUserFromDB(username);
        }
    }
}
