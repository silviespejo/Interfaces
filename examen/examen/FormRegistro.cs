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
        public FormRegistro(Datos datos, String usr, String pass)
        {
            InitializeComponent();
            this.datos = datos;
            textBoxUser.Text = usr;
            textBoxPass.Text = pass;
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
                    textBoxNombre.Text, dtpFechaNacimiento.Value);
                if (!datos.existeUser(textBoxUser.Text, textBoxPass.Text))
                {
                    if (datos.esMayorDeEdad(dtpFechaNacimiento.Value))
                    {
                        datos.aniadirUsr(user);
                        this.Close();
                    }
                    else errorProvider4.SetError(dtpFechaNacimiento, "No es mayor de edad");
                }
                else MessageBox.Show("El usuario ya existe");
            }
            else { }
        }

        private bool datosCorrectos()
        {
            // creamos una array de errorProviders para poder asignarlos correctamente el siguiente forEach
            ErrorProvider[] arrayErrorProviders = new ErrorProvider[4] { errorProvider1, errorProvider2, errorProvider3, errorProvider4};

            int i = 0;
            bool datosCorrectos = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Text.Equals(""))
                    {
                        arrayErrorProviders[i].SetError(textBox, "Campo vacío");
                        datosCorrectos = false;
                        ++i;
                    }
                    else if (textBox.Text.Length > 5 && textBox.Name.Equals("textBoxUser"))
                    {
                        arrayErrorProviders[i].SetError(textBox, "Usr no puede tener más de 5 caracteres");
                        datosCorrectos = false;
                    }
                    else if (textBox.Text.Length > 8 && textBox.Name.Equals("textBoxPass"))
                    {
                        arrayErrorProviders[i].SetError(textBox, "Pass no puede tener más de 8 caracteres");
                        datosCorrectos = false;
                    }
                    else
                    {
                        arrayErrorProviders[i].Clear();
                    }
                }

                
            }
            return datosCorrectos;
        }
    }
}
