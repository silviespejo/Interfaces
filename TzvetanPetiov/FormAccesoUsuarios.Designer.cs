
namespace TzvetanPetiov
{
    partial class FormAccesoUsuarios
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.labelUsuariosRegistrados = new System.Windows.Forms.Label();
            this.labelNumUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(75, 40);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(127, 37);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(136, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(90, 107);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(171, 107);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(127, 63);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(136, 20);
            this.textBoxContrasena.TabIndex = 5;
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(57, 66);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(64, 13);
            this.labelContrasena.TabIndex = 4;
            this.labelContrasena.Text = "Contraseña:";
            // 
            // labelUsuariosRegistrados
            // 
            this.labelUsuariosRegistrados.AutoSize = true;
            this.labelUsuariosRegistrados.Location = new System.Drawing.Point(153, 158);
            this.labelUsuariosRegistrados.Name = "labelUsuariosRegistrados";
            this.labelUsuariosRegistrados.Size = new System.Drawing.Size(110, 13);
            this.labelUsuariosRegistrados.TabIndex = 6;
            this.labelUsuariosRegistrados.Text = "Usuarios Registrados:";
            // 
            // labelNumUsuarios
            // 
            this.labelNumUsuarios.AutoSize = true;
            this.labelNumUsuarios.Location = new System.Drawing.Point(265, 158);
            this.labelNumUsuarios.Name = "labelNumUsuarios";
            this.labelNumUsuarios.Size = new System.Drawing.Size(13, 13);
            this.labelNumUsuarios.TabIndex = 7;
            this.labelNumUsuarios.Text = "0";
            // 
            // AccesoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 197);
            this.Controls.Add(this.labelNumUsuarios);
            this.Controls.Add(this.labelUsuariosRegistrados);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Name = "AccesoUsuarios";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Label labelUsuariosRegistrados;
        private System.Windows.Forms.Label labelNumUsuarios;
    }
}

