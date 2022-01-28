
namespace DonantesSangre
{
    partial class FormNuevoDonante
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
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxGrupo = new System.Windows.Forms.GroupBox();
            this.radioButtonAB = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.groupBoxFactor = new System.Windows.Forms.GroupBox();
            this.radioButtonPositivo = new System.Windows.Forms.RadioButton();
            this.radioButtonNegativo = new System.Windows.Forms.RadioButton();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxGrupo.SuspendLayout();
            this.groupBoxFactor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(38, 19);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI:";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(99, 16);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(143, 20);
            this.textBoxDni.TabIndex = 1;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(99, 68);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(143, 20);
            this.textBoxTelefono.TabIndex = 3;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(38, 71);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 2;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(99, 42);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(143, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(38, 45);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre:";
            // 
            // groupBoxGrupo
            // 
            this.groupBoxGrupo.Controls.Add(this.radioButtonAB);
            this.groupBoxGrupo.Controls.Add(this.radioButtonB);
            this.groupBoxGrupo.Controls.Add(this.radioButton0);
            this.groupBoxGrupo.Controls.Add(this.radioButtonA);
            this.groupBoxGrupo.Location = new System.Drawing.Point(32, 94);
            this.groupBoxGrupo.Name = "groupBoxGrupo";
            this.groupBoxGrupo.Size = new System.Drawing.Size(210, 52);
            this.groupBoxGrupo.TabIndex = 6;
            this.groupBoxGrupo.TabStop = false;
            this.groupBoxGrupo.Text = "Grupo:";
            // 
            // radioButtonAB
            // 
            this.radioButtonAB.AutoSize = true;
            this.radioButtonAB.Location = new System.Drawing.Point(164, 19);
            this.radioButtonAB.Name = "radioButtonAB";
            this.radioButtonAB.Size = new System.Drawing.Size(39, 17);
            this.radioButtonAB.TabIndex = 10;
            this.radioButtonAB.TabStop = true;
            this.radioButtonAB.Text = "AB";
            this.radioButtonAB.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(114, 19);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 9;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Location = new System.Drawing.Point(10, 19);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(31, 17);
            this.radioButton0.TabIndex = 7;
            this.radioButton0.TabStop = true;
            this.radioButton0.Text = "0";
            this.radioButton0.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(65, 19);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 8;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // groupBoxFactor
            // 
            this.groupBoxFactor.Controls.Add(this.radioButtonPositivo);
            this.groupBoxFactor.Controls.Add(this.radioButtonNegativo);
            this.groupBoxFactor.Location = new System.Drawing.Point(32, 152);
            this.groupBoxFactor.Name = "groupBoxFactor";
            this.groupBoxFactor.Size = new System.Drawing.Size(210, 52);
            this.groupBoxFactor.TabIndex = 11;
            this.groupBoxFactor.TabStop = false;
            this.groupBoxFactor.Text = "Factor:";
            // 
            // radioButtonPositivo
            // 
            this.radioButtonPositivo.AutoSize = true;
            this.radioButtonPositivo.Location = new System.Drawing.Point(10, 19);
            this.radioButtonPositivo.Name = "radioButtonPositivo";
            this.radioButtonPositivo.Size = new System.Drawing.Size(31, 17);
            this.radioButtonPositivo.TabIndex = 7;
            this.radioButtonPositivo.TabStop = true;
            this.radioButtonPositivo.Text = "+";
            this.radioButtonPositivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegativo
            // 
            this.radioButtonNegativo.AutoSize = true;
            this.radioButtonNegativo.Location = new System.Drawing.Point(65, 19);
            this.radioButtonNegativo.Name = "radioButtonNegativo";
            this.radioButtonNegativo.Size = new System.Drawing.Size(28, 17);
            this.radioButtonNegativo.TabIndex = 8;
            this.radioButtonNegativo.TabStop = true;
            this.radioButtonNegativo.Text = "-";
            this.radioButtonNegativo.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(54, 224);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(135, 224);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormNuevoDonante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 299);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.groupBoxFactor);
            this.Controls.Add(this.groupBoxGrupo);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.labelDni);
            this.Name = "FormNuevoDonante";
            this.Text = "Nuevo Donante";
            this.groupBoxGrupo.ResumeLayout(false);
            this.groupBoxGrupo.PerformLayout();
            this.groupBoxFactor.ResumeLayout(false);
            this.groupBoxFactor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.GroupBox groupBoxGrupo;
        private System.Windows.Forms.RadioButton radioButtonAB;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.GroupBox groupBoxFactor;
        private System.Windows.Forms.RadioButton radioButtonPositivo;
        private System.Windows.Forms.RadioButton radioButtonNegativo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}