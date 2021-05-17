using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using parque_Business_Layer;


namespace parque_Ui_Layer
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void picboxLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //mantenimientoForm form = new mantenimientoForm();
            //form.Show();
            string username = textBoxUsuario.Text.Trim();
            string pass = textBoxClave.Text.Trim();
            if (ClaseUsuarioBusiness.comprobarPassword(username, pass))
            {
                string succestext = $"Bienvenido {username} , su password ingresado es correcto";
                MessageBox.Show(succestext);
                this.Hide();
                mantenimientoForm form = new mantenimientoForm();
                form.Show();
            }
            else
            {
                string failtext = $"Usuario y/o password son incorrectos";
                MessageBox.Show(failtext);
            }
        }

        private void picboxSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
