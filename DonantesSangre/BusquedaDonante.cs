using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonantesSangre
{
    public partial class FormBusquedaDonante : Form
    {
        List<Usuario> listaUsuarios;
        public FormBusquedaDonante()
        {
            InitializeComponent();
        }

        public FormBusquedaDonante(List<Usuario> listaUsuarios)
        {
            InitializeComponent();
            this.listaUsuarios = listaUsuarios;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String dni = textBoxDni.Text;
            foreach (Usuario usr in listaUsuarios)
                if (usr.Dni.Equals(dni) && usr.Activo == true) textBoxMostrar.Text = usr.ToString();
            textBoxDni.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
