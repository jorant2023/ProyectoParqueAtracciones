
namespace parque_Ui_Layer
{
    partial class mantenimientoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditarUsuario = new System.Windows.Forms.Button();
            this.buttonMantenimientoSalir = new System.Windows.Forms.Button();
            this.buttonAgregarUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEditarUsuario);
            this.panel1.Controls.Add(this.buttonMantenimientoSalir);
            this.panel1.Controls.Add(this.buttonAgregarUsuario);
            this.panel1.Location = new System.Drawing.Point(41, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 254);
            this.panel1.TabIndex = 0;
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.Location = new System.Drawing.Point(305, 36);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(138, 55);
            this.buttonEditarUsuario.TabIndex = 2;
            this.buttonEditarUsuario.Text = "LISTAR USUARIO";
            this.buttonEditarUsuario.UseVisualStyleBackColor = true;
            this.buttonEditarUsuario.Click += new System.EventHandler(this.buttonEditarUsuario_Click);
            // 
            // buttonMantenimientoSalir
            // 
            this.buttonMantenimientoSalir.Location = new System.Drawing.Point(216, 212);
            this.buttonMantenimientoSalir.Name = "buttonMantenimientoSalir";
            this.buttonMantenimientoSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonMantenimientoSalir.TabIndex = 1;
            this.buttonMantenimientoSalir.Text = "SALIR";
            this.buttonMantenimientoSalir.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarUsuario
            // 
            this.buttonAgregarUsuario.Location = new System.Drawing.Point(63, 36);
            this.buttonAgregarUsuario.Name = "buttonAgregarUsuario";
            this.buttonAgregarUsuario.Size = new System.Drawing.Size(138, 55);
            this.buttonAgregarUsuario.TabIndex = 0;
            this.buttonAgregarUsuario.Text = "AGREGAR USUARIO";
            this.buttonAgregarUsuario.UseVisualStyleBackColor = true;
            this.buttonAgregarUsuario.Click += new System.EventHandler(this.buttonAgregarUsuario_Click);
            // 
            // mantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Name = "mantenimientoForm";
            this.Text = "MANTENIMIENTO DE USUARIOS";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMantenimientoSalir;
        private System.Windows.Forms.Button buttonAgregarUsuario;
        private System.Windows.Forms.Button buttonEditarUsuario;
    }
}