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
        public agregarUsuarioForm()
        {
            InitializeComponent();
        }

        private void buttonConfirmarAgregar_Click(object sender, EventArgs e)
        {
           
            ClaseUsuarioBusiness.insertarUsuario(Convert.ToInt32(textBoxIdPersona.Text), Convert.ToInt32(textBoxIdRol.Text), textBoxUsuario.Text,textBoxClave.Text);
            
        }
    }
}
