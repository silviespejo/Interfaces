using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class FormAccesoUsuarios : Form
    {
        Datos datos;
        public FormAccesoUsuarios()
        {
            InitializeComponent();
            datos = new Datos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Queres cerrar el formulario?", "Confirmar", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String usr = textBoxUser.Text, pass = textBoxPass.Text;

            if (!datos.existeUser(usr))// si el usr no existe le abrimos el FormRegisto
            {
                FormRegistro formRegistro = new FormRegistro(datos);
                formRegistro.ShowDialog();
            }
            else // sino le abrimos el FormComentario
            {
                FormComentario formComentario = new FormComentario();
            }
        }
    }
}
