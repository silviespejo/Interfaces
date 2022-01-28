
namespace DonantesSangre
{
    partial class FormGestionDonantes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDonantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDonanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDonanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busuqedaDonanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDisponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadDeTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDonantesToolStripMenuItem,
            this.solicitudesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónDonantesToolStripMenuItem
            // 
            this.gestiónDonantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDonanteToolStripMenuItem,
            this.bajaDonanteToolStripMenuItem,
            this.busuqedaDonanteToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.gestiónDonantesToolStripMenuItem.Name = "gestiónDonantesToolStripMenuItem";
            this.gestiónDonantesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestiónDonantesToolStripMenuItem.Text = "Resgistro Donantes";
            // 
            // nuevoDonanteToolStripMenuItem
            // 
            this.nuevoDonanteToolStripMenuItem.Name = "nuevoDonanteToolStripMenuItem";
            this.nuevoDonanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoDonanteToolStripMenuItem.Text = "Nuevo Donante";
            this.nuevoDonanteToolStripMenuItem.Click += new System.EventHandler(this.nuevoDonanteToolStripMenuItem_Click);
            // 
            // bajaDonanteToolStripMenuItem
            // 
            this.bajaDonanteToolStripMenuItem.Name = "bajaDonanteToolStripMenuItem";
            this.bajaDonanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bajaDonanteToolStripMenuItem.Text = "Baja Donante";
            this.bajaDonanteToolStripMenuItem.Click += new System.EventHandler(this.bajaDonanteToolStripMenuItem_Click);
            // 
            // busuqedaDonanteToolStripMenuItem
            // 
            this.busuqedaDonanteToolStripMenuItem.Name = "busuqedaDonanteToolStripMenuItem";
            this.busuqedaDonanteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.busuqedaDonanteToolStripMenuItem.Text = "Busqueda Donante";
            this.busuqedaDonanteToolStripMenuItem.Click += new System.EventHandler(this.busuqedaDonanteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDisponiblesToolStripMenuItem,
            this.disponibilidadDeTipoToolStripMenuItem});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // tiposDisponiblesToolStripMenuItem
            // 
            this.tiposDisponiblesToolStripMenuItem.Name = "tiposDisponiblesToolStripMenuItem";
            this.tiposDisponiblesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tiposDisponiblesToolStripMenuItem.Text = "Tipos Disponibles";
            this.tiposDisponiblesToolStripMenuItem.Click += new System.EventHandler(this.tiposDisponiblesToolStripMenuItem_Click);
            // 
            // disponibilidadDeTipoToolStripMenuItem
            // 
            this.disponibilidadDeTipoToolStripMenuItem.Name = "disponibilidadDeTipoToolStripMenuItem";
            this.disponibilidadDeTipoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.disponibilidadDeTipoToolStripMenuItem.Text = "Disponibilidad de tipo";
            // 
            // FormGestionDonantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGestionDonantes";
            this.Text = "Gestión Donantes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDonantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDonanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDonanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busuqedaDonanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDisponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadDeTipoToolStripMenuItem;
    }
}

