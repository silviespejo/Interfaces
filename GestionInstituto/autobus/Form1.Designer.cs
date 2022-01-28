
namespace autobus
{
    partial class FormAutobus
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonComprarBilletes = new System.Windows.Forms.Button();
            this.buttonMostrarDatos = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(50, 26);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(150, 46);
            this.buttonRegistrar.TabIndex = 0;
            this.buttonRegistrar.Text = "Registrar Usuario";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonComprarBilletes
            // 
            this.buttonComprarBilletes.Location = new System.Drawing.Point(50, 78);
            this.buttonComprarBilletes.Name = "buttonComprarBilletes";
            this.buttonComprarBilletes.Size = new System.Drawing.Size(150, 46);
            this.buttonComprarBilletes.TabIndex = 1;
            this.buttonComprarBilletes.Text = "Comprar Billetes";
            this.buttonComprarBilletes.UseVisualStyleBackColor = true;
            this.buttonComprarBilletes.Click += new System.EventHandler(this.buttonComprarBilletes_Click);
            // 
            // buttonMostrarDatos
            // 
            this.buttonMostrarDatos.Location = new System.Drawing.Point(50, 130);
            this.buttonMostrarDatos.Name = "buttonMostrarDatos";
            this.buttonMostrarDatos.Size = new System.Drawing.Size(150, 46);
            this.buttonMostrarDatos.TabIndex = 2;
            this.buttonMostrarDatos.Text = "Mostrar Datos";
            this.buttonMostrarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarDatos.Click += new System.EventHandler(this.buttonMostrarDatos_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(50, 182);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(150, 46);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 308);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonMostrarDatos);
            this.Controls.Add(this.buttonComprarBilletes);
            this.Controls.Add(this.buttonRegistrar);
            this.Name = "FormAutobus";
            this.Text = "Billetes Autobús";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonComprarBilletes;
        private System.Windows.Forms.Button buttonMostrarDatos;
        private System.Windows.Forms.Button buttonSalir;
    }
}

