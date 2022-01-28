using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TzvetanPetiov
{
    public partial class FormRegistro : Form
    {
        FormAccesoUsuarios formAccesoUsuarios;
        public FormRegistro()
        {
            InitializeComponent();
        }
        public FormRegistro(FormAccesoUsuarios formAccesoUsuarios)
        {
            InitializeComponent();
            this.formAccesoUsuarios = formAccesoUsuarios;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (comprobar())
            {
                String usr = textBoxUsuario.Text, contrasena = textBoxContrasena.Text, nombre = textBoxNombre.Text;
                DateTime fechaNacimiento = dateTimePicker1.Value;

                if (!boolUsuarioExistente(usr))
                {
                    Array.Resize(ref formAccesoUsuarios.arrayUsuarios, formAccesoUsuarios.arrayUsuarios.Length + 1);
                    formAccesoUsuarios.arrayUsuarios[formAccesoUsuarios.arrayUsuarios.Length - 1] = new Usuario(usr, contrasena, nombre, fechaNacimiento);

                    MessageBox.Show("usuario registrado con éxito");
                    Utils.sumarUsuario();
                    limpiar();
                }
                else 
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }
        }

        private bool boolUsuarioExistente(String usr) {
            bool usuarioExistente = false;
            for (int i = 0; i < formAccesoUsuarios.arrayUsuarios.Length; ++i)
            {
                if (usr.Equals(formAccesoUsuarios.arrayUsuarios[i].Usr)) usuarioExistente = true;
            }
            return usuarioExistente;
        }

        private bool comprobar() {
            bool aux = true;
            if (textBoxContrasena.Text.Length > 8)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxContrasena, "La contraseña excede el máximo");
                aux = false;
            }
            if (textBoxUsuario.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBoxContrasena, "La contraseña está vacía");
                aux = false;
            }
            if (textBoxUsuario.Text.Length > 5)
            {
                errorProvider2.Clear();
                errorProvider2.SetError(textBoxUsuario, "El usuario excede el máximo");
                aux = false;
            }
            if (textBoxUsuario.Text == "")
            {
                errorProvider2.Clear();
                errorProvider2.SetError(textBoxUsuario, "El usuario está vacío");
                aux = false;
            }
            return aux;
        }

        private void limpiar() {
            textBoxContrasena.Clear();
            textBoxNombre.Clear();
            textBoxUsuario.Clear();
        }
    }
}
