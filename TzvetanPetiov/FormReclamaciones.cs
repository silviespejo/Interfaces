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
    public partial class FormReclamaciones : Form
    {
        private Usuario usuario;
        public FormReclamaciones()
        {
            InitializeComponent();
        }

        public FormReclamaciones(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            labelNombreUsuario.Text = usuario.Nombre;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxComentarios.Text != "")
            {
                usuario.Queja = textBoxComentarios.Text;
                textBoxComentarios.Clear();
                errorProvider1.Clear();
                this.Close();
            }
            else
            {
                errorProvider1.SetError(textBoxComentarios, "Debes poner un comentario");
            }
        }
    }
}
