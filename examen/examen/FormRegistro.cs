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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (datosCorrectos())
            {
                User user = new User(textBoxUser.Text, textBoxPass.Text,
                    textBoxNombre.Text, dateTimePicker1.Value);
                datos.aniadirUsr(user);
                this.Close();
            }
            else { }
        }

        private bool datosCorrectos()
        {
            bool datosCorrectos = true;
            /*foreach (Control control in FormRegistro.ControlCollection)
            {
            }*/
            if (textBoxNombre.Text.Equals(""))
            {
                errorProvider1.SetError(textBoxNombre, "Campo obligatorio");
                datosCorrectos = false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (textBoxPass.Text.Equals(""))
            {
                errorProvider2.SetError(textBoxPass, "Campo obligatorio");
                datosCorrectos = false;
            }
            else
            {
                errorProvider2.Clear();
            }
            if (textBoxUser.Text.Equals(""))
            {
                errorProvider3.SetError(textBoxUser, "Campo obligatorio");
                datosCorrectos = false;
            }
            else
            {
                errorProvider3.Clear();
            }
            return datosCorrectos;
        }
    }
}
