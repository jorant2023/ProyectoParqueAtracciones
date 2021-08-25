
namespace parque_Ui_Layer
{
    partial class loginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxSalir = new System.Windows.Forms.PictureBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.labelClave = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.picboxLogin = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.picboxSalir);
            this.panelLogin.Controls.Add(this.textBoxClave);
            this.panelLogin.Controls.Add(this.labelClave);
            this.panelLogin.Controls.Add(this.textBoxUsuario);
            this.panelLogin.Controls.Add(this.labelUsuario);
            this.panelLogin.Controls.Add(this.picboxLogin);
            this.panelLogin.Location = new System.Drawing.Point(28, 37);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(595, 273);
            this.panelLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(417, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "SALIR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(391, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ENTRAR";
            // 
            // picboxSalir
            // 
            this.picboxSalir.BackgroundImage = global::parque_Ui_Layer.Properties.Resources.boton_rojo_glow_256;
            this.picboxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxSalir.Location = new System.Drawing.Point(495, 147);
            this.picboxSalir.Name = "picboxSalir";
            this.picboxSalir.Size = new System.Drawing.Size(43, 40);
            this.picboxSalir.TabIndex = 5;
            this.picboxSalir.TabStop = false;
            this.picboxSalir.Click += new System.EventHandler(this.picboxSalir_Click);
            // 
            // textBoxClave
            // 
            this.textBoxClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClave.Location = new System.Drawing.Point(130, 147);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.PasswordChar = '*';
            this.textBoxClave.Size = new System.Drawing.Size(160, 31);
            this.textBoxClave.TabIndex = 4;
            // 
            // labelClave
            // 
            this.labelClave.AutoSize = true;
            this.labelClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelClave.Location = new System.Drawing.Point(37, 150);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(87, 25);
            this.labelClave.TabIndex = 3;
            this.labelClave.Text = "CLAVE:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(130, 66);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(161, 31);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelUsuario.Location = new System.Drawing.Point(12, 72);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(112, 25);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "USUARIO:";
            // 
            // picboxLogin
            // 
            this.picboxLogin.BackColor = System.Drawing.Color.Transparent;
            this.picboxLogin.BackgroundImage = global::parque_Ui_Layer.Properties.Resources.boton_verde_glow;
            this.picboxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxLogin.Location = new System.Drawing.Point(495, 57);
            this.picboxLogin.Name = "picboxLogin";
            this.picboxLogin.Size = new System.Drawing.Size(43, 40);
            this.picboxLogin.TabIndex = 0;
            this.picboxLogin.TabStop = false;
            this.picboxLogin.Click += new System.EventHandler(this.picboxLogin_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.BackgroundImage = global::parque_Ui_Layer.Properties.Resources.parque_fondo_log;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 340);
            this.Controls.Add(this.panelLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.PictureBox picboxSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

