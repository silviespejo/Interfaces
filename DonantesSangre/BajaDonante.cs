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
    public partial class FormBajaDonante : Form
    {
        FormGestionDonantes formGestionDonantes;
        public FormBajaDonante()
        {
            InitializeComponent();
        }

        public FormBajaDonante(FormGestionDonantes formGestionDonantes)
        {
            InitializeComponent();
            this.formGestionDonantes = formGestionDonantes;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String dni = textBoxDni.Text;
            Usuario usrTemporal = null;
            foreach (Usuario usr in formGestionDonantes.listaUsuarios)
                if (usr.Dni.Equals(dni)) usrTemporal = usr;
            if (MessageBox.Show("Quieres eliminar a este usuario?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                usrTemporal.Activo = false;
                --formGestionDonantes.diccionarioGrupoFactor[usrTemporal.Grupo + usrTemporal.Factor];
            }

            textBoxDni.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
