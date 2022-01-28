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
    public partial class FormAutobus : Form
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        public FormAutobus()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrar formRegistrar = new FormRegistrar(this);
            formRegistrar.Show();
        }

        private void buttonComprarBilletes_Click(object sender, EventArgs e)
        {
            FormComprarBillete FormComprarBillete = new FormComprarBillete(this);
            FormComprarBillete.Show();
        }

        private void buttonMostrarDatos_Click(object sender, EventArgs e)
        {
            FormMostrar FormMostrar = new FormMostrar(listaUsuarios);
            FormMostrar.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void agregarUsuario(Usuario usr)
        {
            if (!comprobarDniUsr(usr)) listaUsuarios.Add(usr);
            else MessageBox.Show("DNI usuario existente!");
        }

        public Boolean comprobarDniUsr(Usuario usr) {

            Boolean dniRepetido = false;

            foreach (Usuario user in listaUsuarios)
                if (user.GetDni() == usr.GetDni()) dniRepetido = true;

            return dniRepetido;
        }

        public void comprarBillete(String dni, int numAsiento)
        {
            Boolean dniEncontrado = false, asientoEncontrado = false;
            foreach (Usuario usrsDni in listaUsuarios)
            {
                if (usrsDni.GetDni().Equals(dni))
                {
                    dniEncontrado = true;
                    
                    foreach (Usuario usrsAsiento in listaUsuarios)
                    {
                        if (usrsAsiento.GetAsiento() == numAsiento) asientoEncontrado = true;
                    }
                    if (asientoEncontrado) MessageBox.Show("El asiento "+numAsiento+" ya está ocupado.");
                    else                   usrsDni.SetAsiento(numAsiento);
                }
            }
            if (!dniEncontrado) MessageBox.Show("DNI no encontrado.");
        }
    }
}
