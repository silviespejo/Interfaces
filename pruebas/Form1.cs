﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void Validating(object sender, CancelEventArgs e)
        {
            TextBox textBoxNombre = (TextBox)sender;
            if (textBoxNombre.Text == "")
            {
                textBoxResultado.Text = "error";
            }
        }
    }
}
