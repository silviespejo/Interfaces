
namespace autobus
{
    partial class FormRegistrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(69, 12);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(183, 20);
            this.textBoxDni.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(69, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(183, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(69, 132);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrar.TabIndex = 5;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(150, 132);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(69, 64);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(183, 20);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección:";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(69, 90);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(183, 20);
            this.textBoxTelefono.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono:";
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 189);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistrar";
            this.Text = "Resgistrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label4;
    }
}