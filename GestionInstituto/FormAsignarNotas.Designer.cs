
namespace GestionInstituto
{
    partial class FormAsignarNotas
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
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panelTextBoxModulos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxModulo1 = new System.Windows.Forms.TextBox();
            this.textBoxModulo2 = new System.Windows.Forms.TextBox();
            this.textBoxModulo3 = new System.Windows.Forms.TextBox();
            this.labelModulos = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelTextBoxModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(211, 25);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(76, 27);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(129, 20);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(41, 30);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 2;
            this.labelDni.Text = "DNI:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(147, 81);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panelTextBoxModulos
            // 
            this.panelTextBoxModulos.Controls.Add(this.label1);
            this.panelTextBoxModulos.Controls.Add(this.label3);
            this.panelTextBoxModulos.Controls.Add(this.label2);
            this.panelTextBoxModulos.Controls.Add(this.textBoxModulo1);
            this.panelTextBoxModulos.Controls.Add(this.textBoxModulo2);
            this.panelTextBoxModulos.Controls.Add(this.textBoxModulo3);
            this.panelTextBoxModulos.Location = new System.Drawing.Point(331, 25);
            this.panelTextBoxModulos.Name = "panelTextBoxModulos";
            this.panelTextBoxModulos.Size = new System.Drawing.Size(173, 99);
            this.panelTextBoxModulos.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // textBoxModulo1
            // 
            this.textBoxModulo1.Location = new System.Drawing.Point(95, 11);
            this.textBoxModulo1.Name = "textBoxModulo1";
            this.textBoxModulo1.Size = new System.Drawing.Size(58, 20);
            this.textBoxModulo1.TabIndex = 15;
            this.textBoxModulo1.Visible = false;
            // 
            // textBoxModulo2
            // 
            this.textBoxModulo2.Location = new System.Drawing.Point(95, 37);
            this.textBoxModulo2.Name = "textBoxModulo2";
            this.textBoxModulo2.Size = new System.Drawing.Size(58, 20);
            this.textBoxModulo2.TabIndex = 17;
            this.textBoxModulo2.Visible = false;
            // 
            // textBoxModulo3
            // 
            this.textBoxModulo3.Location = new System.Drawing.Point(95, 63);
            this.textBoxModulo3.Name = "textBoxModulo3";
            this.textBoxModulo3.Size = new System.Drawing.Size(58, 20);
            this.textBoxModulo3.TabIndex = 19;
            this.textBoxModulo3.Visible = false;
            // 
            // labelModulos
            // 
            this.labelModulos.AutoSize = true;
            this.labelModulos.Location = new System.Drawing.Point(384, 9);
            this.labelModulos.Name = "labelModulos";
            this.labelModulos.Size = new System.Drawing.Size(50, 13);
            this.labelModulos.TabIndex = 23;
            this.labelModulos.Text = "Módulos:";
            this.labelModulos.Visible = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(66, 81);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 25;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormAsignarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 285);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.panelTextBoxModulos);
            this.Controls.Add(this.labelModulos);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Name = "FormAsignarNotas";
            this.Text = "FormAsignarNotas";
            this.panelTextBoxModulos.ResumeLayout(false);
            this.panelTextBoxModulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Panel panelTextBoxModulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxModulo1;
        private System.Windows.Forms.TextBox textBoxModulo2;
        private System.Windows.Forms.TextBox textBoxModulo3;
        private System.Windows.Forms.Label labelModulos;
        private System.Windows.Forms.Button buttonGuardar;
    }
}