﻿using System;
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

        private void bajaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBajaAlumno formBajaAlumno = new FormBajaAlumno();
            formBajaAlumno.Show();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaTodos formConsultaTodos = new FormConsultaTodos();
            formConsultaTodos.Show();
        }
    }
}
