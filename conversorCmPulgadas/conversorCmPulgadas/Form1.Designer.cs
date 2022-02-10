
namespace conversorCmPulgadas
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
            this.textBoxCm = new System.Windows.Forms.TextBox();
            this.textBoxPulgadas = new System.Windows.Forms.TextBox();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCm
            // 
            this.textBoxCm.Location = new System.Drawing.Point(45, 52);
            this.textBoxCm.Name = "textBoxCm";
            this.textBoxCm.Size = new System.Drawing.Size(214, 23);
            this.textBoxCm.TabIndex = 0;
            this.textBoxCm.TextChanged += new System.EventHandler(this.textBoxCm_TextChanged);
            // 
            // textBoxPulgadas
            // 
            this.textBoxPulgadas.Location = new System.Drawing.Point(302, 52);
            this.textBoxPulgadas.Name = "textBoxPulgadas";
            this.textBoxPulgadas.Size = new System.Drawing.Size(209, 23);
            this.textBoxPulgadas.TabIndex = 1;
            this.textBoxPulgadas.TextChanged += new System.EventHandler(this.textBoxPulgadas_TextChanged);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Enabled = false;
            this.textBoxInfo.Location = new System.Drawing.Point(173, 124);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(209, 23);
            this.textBoxInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 196);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxPulgadas);
            this.Controls.Add(this.textBoxCm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCm;
        private System.Windows.Forms.TextBox textBoxPulgadas;
        private System.Windows.Forms.TextBox textBoxInfo;
    }
}

