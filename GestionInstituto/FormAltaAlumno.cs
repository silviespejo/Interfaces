using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInstituto
{
    public partial class FormAltaAlumno : Form
    {
        public FormAltaAlumno()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            String nombre = textBoxNombre.Text, apellidos = textBoxApellidos.Text, dni = textBoxDni.Text,
                mail = textBoxMail.Text, nombreCurso = seleccinarCurso(), grupo = seleccionarGrupo();
            Dictionary<String, bool> modulosActivos = asignarModulos();
            Alumno alumno = new Alumno(nombre, apellidos, dni, mail, nombreCurso, grupo, modulosActivos);
            // textBoxInfo.Text = "El alumno "+nombre+" se ha creado correctamente.";
            limpiar();
        }

        private Dictionary<string, bool> asignarModulos()
        {
            // esta función nos comprueba que checkboxes están seleccionados,
            // y añade el resultado a un diccionario
            Dictionary<String, bool> modulos = new Dictionary<string, bool>();
            if (radioButton1DAM.Checked == true) // si esta seleccionado 1ºDAM
            {

                textBoxInfo.Text = ("");
                foreach (Control control in groupBoxModulos1.Controls)
                {
                    CheckBox checkBox = control as CheckBox;
                    modulos.Add(checkBox.Text, checkBox.Checked);
                    textBoxInfo.Text += (checkBox.Text +"="+ checkBox.Checked+" | ");
                }

                /*
                if (checkBoxProgramacion.Checked == true)
                    modulos.Add("Programacion", true);
                else
                    modulos.Add("Programacion", false);
                if (checkBoxEntornos.Checked == true)
                    modulos.Add("Entornos", true);
                else
                    modulos.Add("Entornos", false);
                if (checkBoxBBDD.Checked == true)
                    modulos.Add("BBDD", true);
                else
                    modulos.Add("BBDD", false);
                */
            }
            else if (radioButton2DAM.Checked == true) // si esta seleccionado 2ºDAM
            {
                if (checkBoxInterfaces.Checked == true)
                    modulos.Add("Interfaces", true);
                else
                    modulos.Add("Interfaces", false);
                if (checkBoxSGE.Checked == true)
                    modulos.Add("SGE", true);
                else
                    modulos.Add("SGE", false);
                if (checkBoxProcesos.Checked == true)
                    modulos.Add("Procesos", true);
                else
                    modulos.Add("Procesos", false);
            }
            else MessageBox.Show("No has seleccionado ningún curso");

            return modulos;
        }

        private string seleccionarGrupo()
        {
            if (radioButtonA.Checked == true) return "A";
            else return "B";
        }

        private String seleccinarCurso() 
        {
            if (radioButton1DAM.Checked == true) return "1º DAM";
            else return "2º DAM";
        }

        private void checkBoxTodos1_CheckedChanged(object sender, EventArgs e)
        {
            // cada vez checkBoxTodos1 cambie de valor se ejecutará
            if (checkBoxTodos1.Checked == true)
            {
                checkBoxProgramacion.Checked = true;
                checkBoxEntornos.Checked = true;
                checkBoxBBDD.Checked = true;
            }
            else
            {
                checkBoxProgramacion.Checked = false;
                checkBoxEntornos.Checked = false;
                checkBoxBBDD.Checked = false;
            }
        }

        private void checkBoxTodos2_CheckedChanged(object sender, EventArgs e)
        {
            // cada vez checkBoxTodos2 cambie de valor se ejecutará
            if (checkBoxTodos2.Checked == true)
            {
                checkBoxInterfaces.Checked = true;
                checkBoxProcesos.Checked = true;
                checkBoxSGE.Checked = true;
            }
            else
            {
                checkBoxInterfaces.Checked = false;
                checkBoxProcesos.Checked = false;
                checkBoxSGE.Checked = false;
            }
        }

        private void limpiar()
        {
            textBoxNombre.Text = "";
            textBoxApellidos.Text = "";
            textBoxDni.Text = "";
            textBoxMail.Text = "";
            radioButton1DAM.Checked = false;
            radioButton2DAM.Checked = false;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            checkBoxBBDD.Checked = false;
            checkBoxEntornos.Checked = false;
            checkBoxInterfaces.Checked = false;
            checkBoxProcesos.Checked = false;
            checkBoxProgramacion.Checked = false;
            checkBoxSGE.Checked = false;
            checkBoxTodos1.Checked = false;
            checkBoxTodos2.Checked = false;
        }
    }
}
