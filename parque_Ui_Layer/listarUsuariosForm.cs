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


namespace parque_Ui_Layer
{
    public partial class listarUsuariosForm : Form
    {
        public listarUsuariosForm()
        {
            InitializeComponent();

        }

        private void listarBasico()
        {
            
                datagridListaUsuarios.DataSource = ClaseUsuarioBusiness.listarUsuariosBasico();

        }

        private void listarUsuariosForm_Load(object sender, EventArgs e)
        {
            this.listarBasico();
            datagridListaUsuarios.AutoResizeColumns();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            mantenimientoForm form = new mantenimientoForm();
            form.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                    
            string username = datagridListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            this.Hide();

            agregarUsuarioForm form = new agregarUsuarioForm(username);
            form.Show();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string username = datagridListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            ClaseUsuarioBusiness.eliminarUsuario(username);
            this.listarBasico();

        }
    }
}
