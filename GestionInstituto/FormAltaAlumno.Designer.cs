
namespace GestionInstituto
{
    partial class FormAltaAlumno
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.radioButton1DAM = new System.Windows.Forms.RadioButton();
            this.groupBoxCurso = new System.Windows.Forms.GroupBox();
            this.radioButton2DAM = new System.Windows.Forms.RadioButton();
            this.groupBoxModulos1 = new System.Windows.Forms.GroupBox();
            this.checkBoxTodos1 = new System.Windows.Forms.CheckBox();
            this.checkBoxBBDD = new System.Windows.Forms.CheckBox();
            this.checkBoxEntornos = new System.Windows.Forms.CheckBox();
            this.checkBoxProgramacion = new System.Windows.Forms.CheckBox();
            this.groupBoxModulos2 = new System.Windows.Forms.GroupBox();
            this.checkBoxTodos2 = new System.Windows.Forms.CheckBox();
            this.checkBoxProcesos = new System.Windows.Forms.CheckBox();
            this.checkBoxSGE = new System.Windows.Forms.CheckBox();
            this.checkBoxInterfaces = new System.Windows.Forms.CheckBox();
            this.groupBoxGrupo = new System.Windows.Forms.GroupBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.groupBoxCurso.SuspendLayout();
            this.groupBoxModulos1.SuspendLayout();
            this.groupBoxModulos2.SuspendLayout();
            this.groupBoxGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(113, 25);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(159, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(113, 51);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(159, 20);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "DNi:";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(113, 77);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(159, 20);
            this.textBoxDni.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mail:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(113, 103);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(159, 20);
            this.textBoxMail.TabIndex = 8;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(74, 155);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 12;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(155, 155);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // radioButton1DAM
            // 
            this.radioButton1DAM.AutoSize = true;
            this.radioButton1DAM.Location = new System.Drawing.Point(6, 19);
            this.radioButton1DAM.Name = "radioButton1DAM";
            this.radioButton1DAM.Size = new System.Drawing.Size(62, 17);
            this.radioButton1DAM.TabIndex = 14;
            this.radioButton1DAM.TabStop = true;
            this.radioButton1DAM.Text = "1º DAM";
            this.radioButton1DAM.UseVisualStyleBackColor = true;
            // 
            // groupBoxCurso
            // 
            this.groupBoxCurso.Controls.Add(this.radioButton2DAM);
            this.groupBoxCurso.Controls.Add(this.radioButton1DAM);
            this.groupBoxCurso.Location = new System.Drawing.Point(289, 25);
            this.groupBoxCurso.Name = "groupBoxCurso";
            this.groupBoxCurso.Size = new System.Drawing.Size(151, 46);
            this.groupBoxCurso.TabIndex = 15;
            this.groupBoxCurso.TabStop = false;
            this.groupBoxCurso.Text = "Curso:";
            // 
            // radioButton2DAM
            // 
            this.radioButton2DAM.AutoSize = true;
            this.radioButton2DAM.Location = new System.Drawing.Point(74, 19);
            this.radioButton2DAM.Name = "radioButton2DAM";
            this.radioButton2DAM.Size = new System.Drawing.Size(62, 17);
            this.radioButton2DAM.TabIndex = 16;
            this.radioButton2DAM.TabStop = true;
            this.radioButton2DAM.Text = "2º DAM";
            this.radioButton2DAM.UseVisualStyleBackColor = true;
            // 
            // groupBoxModulos1
            // 
            this.groupBoxModulos1.Controls.Add(this.checkBoxTodos1);
            this.groupBoxModulos1.Controls.Add(this.checkBoxBBDD);
            this.groupBoxModulos1.Controls.Add(this.checkBoxEntornos);
            this.groupBoxModulos1.Controls.Add(this.checkBoxProgramacion);
            this.groupBoxModulos1.Location = new System.Drawing.Point(289, 80);
            this.groupBoxModulos1.Name = "groupBoxModulos1";
            this.groupBoxModulos1.Size = new System.Drawing.Size(312, 46);
            this.groupBoxModulos1.TabIndex = 18;
            this.groupBoxModulos1.TabStop = false;
            this.groupBoxModulos1.Text = "Módulos 1º:";
            // 
            // checkBoxTodos1
            // 
            this.checkBoxTodos1.AutoSize = true;
            this.checkBoxTodos1.Location = new System.Drawing.Point(250, 19);
            this.checkBoxTodos1.Name = "checkBoxTodos1";
            this.checkBoxTodos1.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTodos1.TabIndex = 22;
            this.checkBoxTodos1.Text = "Todos";
            this.checkBoxTodos1.UseVisualStyleBackColor = true;
            this.checkBoxTodos1.CheckedChanged += new System.EventHandler(this.checkBoxTodos1_CheckedChanged);
            // 
            // checkBoxBBDD
            // 
            this.checkBoxBBDD.AutoSize = true;
            this.checkBoxBBDD.Location = new System.Drawing.Point(177, 19);
            this.checkBoxBBDD.Name = "checkBoxBBDD";
            this.checkBoxBBDD.Size = new System.Drawing.Size(56, 17);
            this.checkBoxBBDD.TabIndex = 21;
            this.checkBoxBBDD.Text = "BBDD";
            this.checkBoxBBDD.UseVisualStyleBackColor = true;
            // 
            // checkBoxEntornos
            // 
            this.checkBoxEntornos.AutoSize = true;
            this.checkBoxEntornos.Location = new System.Drawing.Point(103, 19);
            this.checkBoxEntornos.Name = "checkBoxEntornos";
            this.checkBoxEntornos.Size = new System.Drawing.Size(68, 17);
            this.checkBoxEntornos.TabIndex = 20;
            this.checkBoxEntornos.Text = "Entornos";
            this.checkBoxEntornos.UseVisualStyleBackColor = true;
            // 
            // checkBoxProgramacion
            // 
            this.checkBoxProgramacion.AutoSize = true;
            this.checkBoxProgramacion.Location = new System.Drawing.Point(6, 19);
            this.checkBoxProgramacion.Name = "checkBoxProgramacion";
            this.checkBoxProgramacion.Size = new System.Drawing.Size(91, 17);
            this.checkBoxProgramacion.TabIndex = 19;
            this.checkBoxProgramacion.Text = "Programacion";
            this.checkBoxProgramacion.UseVisualStyleBackColor = true;
            // 
            // groupBoxModulos2
            // 
            this.groupBoxModulos2.Controls.Add(this.checkBoxTodos2);
            this.groupBoxModulos2.Controls.Add(this.checkBoxProcesos);
            this.groupBoxModulos2.Controls.Add(this.checkBoxSGE);
            this.groupBoxModulos2.Controls.Add(this.checkBoxInterfaces);
            this.groupBoxModulos2.Location = new System.Drawing.Point(289, 132);
            this.groupBoxModulos2.Name = "groupBoxModulos2";
            this.groupBoxModulos2.Size = new System.Drawing.Size(312, 46);
            this.groupBoxModulos2.TabIndex = 23;
            this.groupBoxModulos2.TabStop = false;
            this.groupBoxModulos2.Text = "Módulos 2º:";
            // 
            // checkBoxTodos2
            // 
            this.checkBoxTodos2.AutoSize = true;
            this.checkBoxTodos2.Location = new System.Drawing.Point(250, 19);
            this.checkBoxTodos2.Name = "checkBoxTodos2";
            this.checkBoxTodos2.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTodos2.TabIndex = 22;
            this.checkBoxTodos2.Text = "Todos";
            this.checkBoxTodos2.UseVisualStyleBackColor = true;
            this.checkBoxTodos2.CheckedChanged += new System.EventHandler(this.checkBoxTodos2_CheckedChanged);
            // 
            // checkBoxProcesos
            // 
            this.checkBoxProcesos.AutoSize = true;
            this.checkBoxProcesos.Location = new System.Drawing.Point(177, 19);
            this.checkBoxProcesos.Name = "checkBoxProcesos";
            this.checkBoxProcesos.Size = new System.Drawing.Size(70, 17);
            this.checkBoxProcesos.TabIndex = 21;
            this.checkBoxProcesos.Text = "Procesos";
            this.checkBoxProcesos.UseVisualStyleBackColor = true;
            // 
            // checkBoxSGE
            // 
            this.checkBoxSGE.AutoSize = true;
            this.checkBoxSGE.Location = new System.Drawing.Point(103, 19);
            this.checkBoxSGE.Name = "checkBoxSGE";
            this.checkBoxSGE.Size = new System.Drawing.Size(48, 17);
            this.checkBoxSGE.TabIndex = 20;
            this.checkBoxSGE.Text = "SGE";
            this.checkBoxSGE.UseVisualStyleBackColor = true;
            // 
            // checkBoxInterfaces
            // 
            this.checkBoxInterfaces.AutoSize = true;
            this.checkBoxInterfaces.Location = new System.Drawing.Point(6, 19);
            this.checkBoxInterfaces.Name = "checkBoxInterfaces";
            this.checkBoxInterfaces.Size = new System.Drawing.Size(73, 17);
            this.checkBoxInterfaces.TabIndex = 19;
            this.checkBoxInterfaces.Text = "Interfaces";
            this.checkBoxInterfaces.UseVisualStyleBackColor = true;
            // 
            // groupBoxGrupo
            // 
            this.groupBoxGrupo.Controls.Add(this.radioButtonB);
            this.groupBoxGrupo.Controls.Add(this.radioButtonA);
            this.groupBoxGrupo.Location = new System.Drawing.Point(451, 25);
            this.groupBoxGrupo.Name = "groupBoxGrupo";
            this.groupBoxGrupo.Size = new System.Drawing.Size(150, 46);
            this.groupBoxGrupo.TabIndex = 17;
            this.groupBoxGrupo.TabStop = false;
            this.groupBoxGrupo.Text = "Grupo:";
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(88, 19);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 16;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(15, 19);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 14;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Enabled = false;
            this.textBoxInfo.Location = new System.Drawing.Point(289, 194);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(312, 20);
            this.textBoxInfo.TabIndex = 24;
            // 
            // FormAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 243);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.groupBoxGrupo);
            this.Controls.Add(this.groupBoxModulos2);
            this.Controls.Add(this.groupBoxModulos1);
            this.Controls.Add(this.groupBoxCurso);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormAltaAlumno";
            this.Text = "FormAltaAlumno";
            this.groupBoxCurso.ResumeLayout(false);
            this.groupBoxCurso.PerformLayout();
            this.groupBoxModulos1.ResumeLayout(false);
            this.groupBoxModulos1.PerformLayout();
            this.groupBoxModulos2.ResumeLayout(false);
            this.groupBoxModulos2.PerformLayout();
            this.groupBoxGrupo.ResumeLayout(false);
            this.groupBoxGrupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RadioButton radioButton1DAM;
        private System.Windows.Forms.GroupBox groupBoxCurso;
        private System.Windows.Forms.RadioButton radioButton2DAM;
        private System.Windows.Forms.GroupBox groupBoxModulos1;
        private System.Windows.Forms.CheckBox checkBoxTodos1;
        private System.Windows.Forms.CheckBox checkBoxBBDD;
        private System.Windows.Forms.CheckBox checkBoxEntornos;
        private System.Windows.Forms.CheckBox checkBoxProgramacion;
        private System.Windows.Forms.GroupBox groupBoxModulos2;
        private System.Windows.Forms.CheckBox checkBoxTodos2;
        private System.Windows.Forms.CheckBox checkBoxProcesos;
        private System.Windows.Forms.CheckBox checkBoxSGE;
        private System.Windows.Forms.CheckBox checkBoxInterfaces;
        private System.Windows.Forms.GroupBox groupBoxGrupo;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}