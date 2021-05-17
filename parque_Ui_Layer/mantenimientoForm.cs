using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parque_Ui_Layer
{
    public partial class mantenimientoForm : Form
    {
        public mantenimientoForm()
        {
            InitializeComponent();
        }

        private void buttonAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            agregarUsuarioForm form = new agregarUsuarioForm();
            form.Show();
        }

        private void buttonEditarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            listarUsuariosForm form = new listarUsuariosForm();
            form.Show();
        }
    }
}
