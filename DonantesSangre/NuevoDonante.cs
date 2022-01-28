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

            if (grupo != "" && factor != "")
            {
                Usuario usuario = new Usuario(dni, nombre, grupo, factor, telefono);
                FormGestionDonantes.agregarUsuario(usuario);
                textBoxMostrar.Text = "El usuario se ha creado correctamente";
            }

            clear();
        }

        private String asignarGrupo() {
            if (radioButton0.Checked == false && radioButtonA.Checked == false &&
                radioButtonB.Checked == false && radioButtonAB.Checked == false)
            {
                textBoxMostrar.Text = "No has introducido ningún grupo";
                return "";
            }
            else
            {
                if (radioButtonA.Checked) return radioButtonA.Text;
                else if (radioButton0.Checked) return radioButton0.Text;
                else if (radioButtonB.Checked) return radioButtonB.Text;
                else if (radioButtonAB.Checked) return radioButtonAB.Text;
                else return "";
            }
        }

        private String asignarFactor()
        {
            if (radioButtonPositivo.Checked == false && radioButtonNegativo.Checked == false)
            {
                textBoxMostrar.Text = "No has introducido ningún factor";
                return "";
            }
            else
            {
                if (radioButtonPositivo.Checked) return radioButtonPositivo.Text;
                else if (radioButtonNegativo.Checked) return radioButtonNegativo.Text;
                else return "";
            }
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

        private void buttonGenerarUsuarios_Click(object sender, EventArgs e)
        {
            Usuario usuario01 = new Usuario("1", "1", "A", "+", 1);
            Usuario usuario02 = new Usuario("2", "2", "A", "+", 2);
            Usuario usuario03 = new Usuario("3", "3", "0", "+", 3);
            Usuario usuario04 = new Usuario("4", "4", "AB", "-", 4);

            FormGestionDonantes.agregarUsuario(usuario01);
            FormGestionDonantes.agregarUsuario(usuario02);
            FormGestionDonantes.agregarUsuario(usuario03);
            FormGestionDonantes.agregarUsuario(usuario04);

            textBoxMostrar.Text = "Usuarios generados correctamente";
        }
    }
}
