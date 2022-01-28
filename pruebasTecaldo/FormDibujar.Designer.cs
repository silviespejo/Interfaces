
namespace pruebasTecaldo
{
    partial class FormDibujar
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
            this.panelDibujar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelDibujar
            // 
            this.panelDibujar.Location = new System.Drawing.Point(32, 44);
            this.panelDibujar.Name = "panelDibujar";
            this.panelDibujar.Size = new System.Drawing.Size(592, 353);
            this.panelDibujar.TabIndex = 0;
            this.panelDibujar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDibujar_MouseDown);
            this.panelDibujar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormDibujar_MouseUp);
            // 
            // FormDibujar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 409);
            this.Controls.Add(this.panelDibujar);
            this.Name = "FormDibujar";
            this.Text = "Dibujar";
            this.Load += new System.EventHandler(this.FormDibujar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDibujar;
    }
}

