using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInstituto
{
    public partial class FormGestionInstituto : Form
    {
        public FormGestionInstituto()
        {
            InitializeComponent();
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaAlumno formAltaAlumno = new FormAltaAlumno();
            formAltaAlumno.Show();
        }
    }
}
