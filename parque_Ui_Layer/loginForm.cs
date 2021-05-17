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
            this.Hide();

            mantenimientoForm form = new mantenimientoForm();
            form.Show();
        }
    }
}
