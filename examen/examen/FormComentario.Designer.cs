
namespace examen
{
    partial class FormComentario
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
            this.labelNombreUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // labelNombreUser
            // 
            this.labelNombreUser.AutoSize = true;
            this.labelNombreUser.Location = new System.Drawing.Point(170, 54);
            this.labelNombreUser.Name = "labelNombreUser";
            this.labelNombreUser.Size = new System.Drawing.Size(72, 15);
            this.labelNombreUser.TabIndex = 1;
            this.labelNombreUser.Text = "nombreUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comentario:";
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(69, 128);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(454, 90);
            this.textBoxComentario.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(233, 255);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 331);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNombreUser);
            this.Controls.Add(this.label1);
            this.Name = "FormComentario";
            this.Text = "FormComentario";
            this.Load += new System.EventHandler(this.FormComentario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Button buttonGuardar;
    }
}