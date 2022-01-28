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
    public partial class FormAccesoUsuarios : Form
    {
        public Usuario[] arrayUsuarios = new Usuario[0];
        public FormAccesoUsuarios()
        {
            InitializeComponent();
            labelNumUsuarios.Text = arrayUsuarios.Length+"";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas cerrar este formulario?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (arrayUsuarios.Length == 0)
            {
                MessageBox.Show("No existen usuarios");
                FormRegistro formRegistro = new FormRegistro(this);
                formRegistro.Show();
            }
            else
            {
                String Usr = textBoxUsuario.Text, contrasena = textBoxContrasena.Text;
                bool usuarioCorrecto = false;
                Usuario auxUsuario = null;
                for (int i = 0; i < arrayUsuarios.Length; ++i)
                {
                    if (Usr.Equals(arrayUsuarios[i].Usr) && contrasena.Equals(arrayUsuarios[i].Contrasena))
                    {
                        usuarioCorrecto = true;
                        auxUsuario = arrayUsuarios[i];
                    }
                }

                if (usuarioCorrecto)
                {
                    FormReclamaciones formReclamaciones = new FormReclamaciones(auxUsuario);
                    formReclamaciones.Show();
                }
                else
                {
                    FormRegistro formRegistro = new FormRegistro(this);
                    formRegistro.Show();
                }
            }
        }
    }
}
