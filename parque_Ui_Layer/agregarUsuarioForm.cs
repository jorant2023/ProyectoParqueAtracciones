using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parque_Business_Layer;
using parque_Entity_Layer;
namespace parque_Ui_Layer
{
    public partial class agregarUsuarioForm : Form
    {
        string usuario = null;
        public agregarUsuarioForm(string username)
        {
            usuario = username;
            if (usuario!=null)
            {
                
                claseUsuario_Entity usuarioParaEditar = ClaseUsuarioBusiness.getUserFromDB(usuario);
                InitializeComponent();
                textBoxIdPersona.Text = usuarioParaEditar.id_persona.ToString();
                textBoxIdRol.Text = usuarioParaEditar.id_rol.ToString();
                textBoxUsuario.Text = usuarioParaEditar.usuario;
                textBoxUsuario.ReadOnly = true;
                textBoxClave.Text = "1234";
            }
            else InitializeComponent();
        }

        private void buttonConfirmarAgregar_Click(object sender, EventArgs e)
        {



            if (usuario==null)
            {
                ClaseUsuarioBusiness.insertarUsuario(Convert.ToInt32(textBoxIdPersona.Text), Convert.ToInt32(textBoxIdRol.Text), textBoxUsuario.Text, textBoxClave.Text);
                this.Hide();
                listarUsuariosForm form = new listarUsuariosForm();
                form.Show();
            }
            else
            {
                ClaseUsuarioBusiness.modificarUsuario(Convert.ToInt32(textBoxIdPersona.Text), Convert.ToInt32(textBoxIdRol.Text), textBoxUsuario.Text, textBoxClave.Text);
                this.Hide();
                listarUsuariosForm form = new listarUsuariosForm();
                form.Show();

            }



        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            listarUsuariosForm form = new listarUsuariosForm();
            form.Show();
        }
    }
}
