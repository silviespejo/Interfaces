using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace examen
{
    public partial class FormRegistro : Form
    {
        Datos datos;
        public FormRegistro(Datos datos)
        {
            InitializeComponent();
            this.datos = datos;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
