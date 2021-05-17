
namespace parque_Ui_Layer
{
    partial class agregarUsuarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfirmarAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxIdRol = new System.Windows.Forms.TextBox();
            this.textBoxIdPersona = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirmarAgregar
            // 
            this.buttonConfirmarAgregar.Location = new System.Drawing.Point(188, 230);
            this.buttonConfirmarAgregar.Name = "buttonConfirmarAgregar";
            this.buttonConfirmarAgregar.Size = new System.Drawing.Size(125, 23);
            this.buttonConfirmarAgregar.TabIndex = 0;
            this.buttonConfirmarAgregar.Text = "GRABAR USUARIO";
            this.buttonConfirmarAgregar.UseVisualStyleBackColor = true;
            this.buttonConfirmarAgregar.Click += new System.EventHandler(this.buttonConfirmarAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxClave);
            this.panel1.Controls.Add(this.textBoxUsuario);
            this.panel1.Controls.Add(this.textBoxIdRol);
            this.panel1.Controls.Add(this.textBoxIdPersona);
            this.panel1.Controls.Add(this.buttonConfirmarAgregar);
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 282);
            this.panel1.TabIndex = 1;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(200, 178);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(100, 20);
            this.textBoxClave.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(200, 128);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // textBoxIdRol
            // 
            this.textBoxIdRol.Location = new System.Drawing.Point(200, 78);
            this.textBoxIdRol.Name = "textBoxIdRol";
            this.textBoxIdRol.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdRol.TabIndex = 2;
            // 
            // textBoxIdPersona
            // 
            this.textBoxIdPersona.Location = new System.Drawing.Point(200, 28);
            this.textBoxIdPersona.Name = "textBoxIdPersona";
            this.textBoxIdPersona.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdPersona.TabIndex = 1;
            // 
            // agregarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Name = "agregarUsuarioForm";
            this.Text = "agregarUsuarioForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmarAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxClave;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxIdRol;
        private System.Windows.Forms.TextBox textBoxIdPersona;
    }
}