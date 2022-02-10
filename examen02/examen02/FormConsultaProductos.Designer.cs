
namespace examen02
{
    partial class FormConsultaProductos
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
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonPrimero = new System.Windows.Forms.Button();
            this.textBoxStockMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStockMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUnidades = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(419, 123);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.buttonSiguiente.TabIndex = 19;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            // 
            // buttonPrimero
            // 
            this.buttonPrimero.Location = new System.Drawing.Point(419, 94);
            this.buttonPrimero.Name = "buttonPrimero";
            this.buttonPrimero.Size = new System.Drawing.Size(75, 23);
            this.buttonPrimero.TabIndex = 18;
            this.buttonPrimero.Text = "Primero";
            this.buttonPrimero.UseVisualStyleBackColor = true;
            this.buttonPrimero.Click += new System.EventHandler(this.buttonPrimero_Click);
            // 
            // textBoxStockMax
            // 
            this.textBoxStockMax.Enabled = false;
            this.textBoxStockMax.Location = new System.Drawing.Point(192, 139);
            this.textBoxStockMax.Name = "textBoxStockMax";
            this.textBoxStockMax.Size = new System.Drawing.Size(169, 23);
            this.textBoxStockMax.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Stock Máximo:";
            // 
            // textBoxStockMin
            // 
            this.textBoxStockMin.Enabled = false;
            this.textBoxStockMin.Location = new System.Drawing.Point(192, 110);
            this.textBoxStockMin.Name = "textBoxStockMin";
            this.textBoxStockMin.Size = new System.Drawing.Size(169, 23);
            this.textBoxStockMin.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stock Mínimo:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(192, 81);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(169, 23);
            this.textBoxNombre.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.Enabled = false;
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(192, 52);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(169, 23);
            this.textBoxCodigoProducto.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código Producto:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(192, 226);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(169, 23);
            this.textBoxTotal.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total:";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Enabled = false;
            this.textBoxPrecio.Location = new System.Drawing.Point(192, 197);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(169, 23);
            this.textBoxPrecio.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Precio:";
            // 
            // textBoxUnidades
            // 
            this.textBoxUnidades.Enabled = false;
            this.textBoxUnidades.Location = new System.Drawing.Point(192, 168);
            this.textBoxUnidades.Name = "textBoxUnidades";
            this.textBoxUnidades.Size = new System.Drawing.Size(169, 23);
            this.textBoxUnidades.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Unidades:";
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.Location = new System.Drawing.Point(419, 181);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(75, 23);
            this.buttonUltimo.TabIndex = 27;
            this.buttonUltimo.Text = "Ultimo";
            this.buttonUltimo.UseVisualStyleBackColor = true;
            this.buttonUltimo.Click += new System.EventHandler(this.buttonUltimo_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Location = new System.Drawing.Point(419, 152);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(75, 23);
            this.buttonAnterior.TabIndex = 26;
            this.buttonAnterior.Text = "Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            // 
            // FormConsultaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 299);
            this.Controls.Add(this.buttonUltimo);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUnidades);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.buttonPrimero);
            this.Controls.Add(this.textBoxStockMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxStockMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodigoProducto);
            this.Controls.Add(this.label1);
            this.Name = "FormConsultaProductos";
            this.Text = "FormConsultaProductos";
            this.Load += new System.EventHandler(this.FormConsultaProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonPrimero;
        private System.Windows.Forms.TextBox textBoxStockMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStockMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUnidades;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUltimo;
        private System.Windows.Forms.Button buttonAnterior;
    }
}