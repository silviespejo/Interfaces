using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autobus
{
    public partial class FormRegistrar : Form
    {
        FormAutobus formAutobus;
        public FormRegistrar()
        {
            InitializeComponent();
        }

        public FormRegistrar(FormAutobus formAutobus)
        {
            InitializeComponent();
            this.formAutobus = formAutobus;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            String dni       = textBoxDni.Text;
            String nombre    = textBoxNombre.Text;
            String direccion = textBoxDireccion.Text;
            int telefono     = int.Parse(textBoxTelefono.Text);

            Usuario usr = new Usuario(dni, nombre, direccion, telefono);

            formAutobus.agregarUsuario(usr);

            textBoxDireccion.Clear();
            textBoxNombre.Clear();
            textBoxDni.Clear();
            textBoxTelefono.Clear();
        }
    }
}
