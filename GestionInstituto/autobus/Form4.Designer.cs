
namespace autobus
{
    partial class FormComprarBillete
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
            this.textBoxAsiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCompReali = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(90, 25);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(138, 20);
            this.textBoxDni.TabIndex = 1;
            // 
            // textBoxAsiento
            // 
            this.textBoxAsiento.Location = new System.Drawing.Point(90, 51);
            this.textBoxAsiento.Name = "textBoxAsiento";
            this.textBoxAsiento.Size = new System.Drawing.Size(138, 20);
            this.textBoxAsiento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asiento:";
            // 
            // labelCompReali
            // 
            this.labelCompReali.AutoSize = true;
            this.labelCompReali.Location = new System.Drawing.Point(87, 144);
            this.labelCompReali.Name = "labelCompReali";
            this.labelCompReali.Size = new System.Drawing.Size(93, 13);
            this.labelCompReali.TabIndex = 4;
            this.labelCompReali.Text = "Compra Realizada";
            this.labelCompReali.Visible = false;
            // 
            // buttonComprar
            // 
            this.buttonComprar.Location = new System.Drawing.Point(90, 99);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 5;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // FormComprarBillete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 176);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.labelCompReali);
            this.Controls.Add(this.textBoxAsiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.label1);
            this.Name = "FormComprarBillete";
            this.Text = "Comprar Billetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxAsiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCompReali;
        private System.Windows.Forms.Button buttonComprar;
    }
}