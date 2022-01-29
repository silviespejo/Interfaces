
namespace GestionInstituto
{
    partial class FormGestionInstituto
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
            this.matrículaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMAToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ºDAMBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBorrarFichero = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrículaToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matrículaToolStripMenuItem
            // 
            this.matrículaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAlumnoToolStripMenuItem,
            this.bajaAlumnoToolStripMenuItem,
            this.listadoAlumnosToolStripMenuItem});
            this.matrículaToolStripMenuItem.Name = "matrículaToolStripMenuItem";
            this.matrículaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matrículaToolStripMenuItem.Text = "Matrícula";
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta Alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // bajaAlumnoToolStripMenuItem
            // 
            this.bajaAlumnoToolStripMenuItem.Name = "bajaAlumnoToolStripMenuItem";
            this.bajaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.bajaAlumnoToolStripMenuItem.Text = "Baja Alumno";
            this.bajaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.bajaAlumnoToolStripMenuItem_Click);
            // 
            // listadoAlumnosToolStripMenuItem
            // 
            this.listadoAlumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ºDAMAToolStripMenuItem,
            this.ºDAMBToolStripMenuItem,
            this.ºDAMAToolStripMenuItem1,
            this.ºDAMBToolStripMenuItem1,
            this.todosToolStripMenuItem});
            this.listadoAlumnosToolStripMenuItem.Name = "listadoAlumnosToolStripMenuItem";
            this.listadoAlumnosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listadoAlumnosToolStripMenuItem.Text = "Listado Alumnos";
            // 
            // ºDAMAToolStripMenuItem
            // 
            this.ºDAMAToolStripMenuItem.Name = "ºDAMAToolStripMenuItem";
            this.ºDAMAToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ºDAMAToolStripMenuItem.Text = "1º DAM A";
            // 
            // ºDAMBToolStripMenuItem
            // 
            this.ºDAMBToolStripMenuItem.Name = "ºDAMBToolStripMenuItem";
            this.ºDAMBToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ºDAMBToolStripMenuItem.Text = "1º DAM B";
            // 
            // ºDAMAToolStripMenuItem1
            // 
            this.ºDAMAToolStripMenuItem1.Name = "ºDAMAToolStripMenuItem1";
            this.ºDAMAToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.ºDAMAToolStripMenuItem1.Text = "2º DAM A";
            // 
            // ºDAMBToolStripMenuItem1
            // 
            this.ºDAMBToolStripMenuItem1.Name = "ºDAMBToolStripMenuItem1";
            this.ºDAMBToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.ºDAMBToolStripMenuItem1.Text = "2º DAM B";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // buttonBorrarFichero
            // 
            this.buttonBorrarFichero.Location = new System.Drawing.Point(229, 212);
            this.buttonBorrarFichero.Name = "buttonBorrarFichero";
            this.buttonBorrarFichero.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarFichero.TabIndex = 1;
            this.buttonBorrarFichero.Text = "Borrar";
            this.buttonBorrarFichero.UseVisualStyleBackColor = true;
            this.buttonBorrarFichero.Click += new System.EventHandler(this.buttonBorrarFichero_Click);
            // 
            // FormGestionInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 367);
            this.Controls.Add(this.buttonBorrarFichero);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGestionInstituto";
            this.Text = "Gestión Instituto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matrículaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºDAMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºDAMBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºDAMAToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ºDAMBToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.Button buttonBorrarFichero;
    }
}

