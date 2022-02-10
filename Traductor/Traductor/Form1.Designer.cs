
namespace Traductor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSinTraducir = new System.Windows.Forms.TextBox();
            this.buttonTraducir = new System.Windows.Forms.Button();
            this.textBoxTraducido = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSinTraducir
            // 
            this.textBoxSinTraducir.Location = new System.Drawing.Point(67, 65);
            this.textBoxSinTraducir.Name = "textBoxSinTraducir";
            this.textBoxSinTraducir.Size = new System.Drawing.Size(192, 23);
            this.textBoxSinTraducir.TabIndex = 0;
            // 
            // buttonTraducir
            // 
            this.buttonTraducir.Location = new System.Drawing.Point(334, 64);
            this.buttonTraducir.Name = "buttonTraducir";
            this.buttonTraducir.Size = new System.Drawing.Size(75, 23);
            this.buttonTraducir.TabIndex = 1;
            this.buttonTraducir.Text = "Traducir";
            this.buttonTraducir.UseVisualStyleBackColor = true;
            this.buttonTraducir.Click += new System.EventHandler(this.buttonTraducir_Click);
            // 
            // textBoxTraducido
            // 
            this.textBoxTraducido.Enabled = false;
            this.textBoxTraducido.Location = new System.Drawing.Point(473, 65);
            this.textBoxTraducido.Name = "textBoxTraducido";
            this.textBoxTraducido.Size = new System.Drawing.Size(192, 23);
            this.textBoxTraducido.TabIndex = 2;
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Enabled = false;
            this.textBoxInfo.Location = new System.Drawing.Point(275, 123);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(192, 23);
            this.textBoxInfo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 168);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxTraducido);
            this.Controls.Add(this.buttonTraducir);
            this.Controls.Add(this.textBoxSinTraducir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSinTraducir;
        private System.Windows.Forms.Button buttonTraducir;
        private System.Windows.Forms.TextBox textBoxTraducido;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}

