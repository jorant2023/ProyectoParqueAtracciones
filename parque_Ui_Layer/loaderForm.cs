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
    public partial class loaderForm : Form
    {
        public loaderForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();

            loginForm form = new loginForm();
            form.Show();
            timer1.Stop();
        }
    }
}
