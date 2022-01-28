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
    public partial class FormNuevoDonante : Form
    {
        FormGestionDonantes FormGestionDonantes;
        public FormNuevoDonante()
        {
            InitializeComponent();
        }

        public FormNuevoDonante(FormGestionDonantes FormGestionDonantes)
        {
            InitializeComponent();
            this.FormGestionDonantes = FormGestionDonantes;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            String dni, nombre, grupo = "", factor = "";
            int telefono;

            dni = textBoxDni.Text;
            nombre = textBoxNombre.Text;
            // evitar errores, por si no se introduce nada en "textBoxTelefono"
            if (textBoxTelefono.Text.Equals("")) telefono = 0;
            else telefono = Int32.Parse(textBoxTelefono.Text);
            grupo  = asignarGrupo();
            factor = asignarFactor();

            Usuario usuario = new Usuario(dni, nombre, grupo, factor, telefono);

            FormGestionDonantes.agregarUsuario(usuario);
            clear();
        }

        private String asignarGrupo() {
            if      (radioButtonA.Checked)  return radioButtonA.Text;
            else if (radioButton0.Checked)  return radioButton0.Text;
            else if (radioButtonB.Checked)  return radioButtonB.Text;
            else if (radioButtonAB.Checked) return radioButtonAB.Text;
            else                            return "";
        }

        private String asignarFactor()
        {
            if      (radioButtonPositivo.Checked) return radioButtonPositivo.Text;
            else if (radioButtonNegativo.Checked) return radioButtonNegativo.Text;
            else                                  return "";
        }

        private void clear() {
            textBoxDni.Clear();
            textBoxNombre.Clear();
            textBoxTelefono.Clear();
            radioButton0.Checked = false;
            radioButtonA.Checked = false;
            radioButtonAB.Checked = false;
            radioButtonB.Checked = false;
            radioButtonNegativo.Checked = false;
            radioButtonPositivo.Checked = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
