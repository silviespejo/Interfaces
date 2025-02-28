﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            if (camposCorrectos())
            {
                // creamos el objeto alumno
                String nombre = textBoxNombre.Text, apellidos = textBoxApellidos.Text, dni = textBoxDni.Text,
                    mail = textBoxMail.Text, nombreCurso = seleccionarCurso(), grupo = seleccionarGrupo();
                Dictionary<String, bool> modulosActivos = asignarModulos();
                Alumno alumno = new Alumno(nombre, apellidos, dni, mail, nombreCurso, grupo, modulosActivos);

                // creamos o abrimos el fichero y añadimos el objeto alumno
                FileStream stream = new FileStream("alumnos.obj", FileMode.Append, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, alumno);
                stream.Close();
                limpiar();
            }
        }

        private Dictionary<string, bool> asignarModulos()
        {
            // esta función nos comprueba que checkboxes están seleccionados,
            // y añade el resultado a un diccionario
            Dictionary<String, bool> modulosActivos = new Dictionary<string, bool>();
            if (radioButton1DAM.Checked == true) // si está seleccionado 1ºDAM
            {
                // Este foreach lo que hace es extraer todos los controles del control "groupBoxModulos1" y uno a uno
                // va extrayendo la info que nos dan los checbox y recopilando esta info en el diccionario
                foreach (Control control in groupBoxModulos1.Controls)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if (!checkBox.Text.Equals("Todos")) // no queremos meter la info en el diccionadio del checkbox "Todos"
                        modulosActivos.Add(checkBox.Text, checkBox.Checked); // vamos añadiendo al diccionario la información sobre los módulos seleccionados
                }
            }
            else if (radioButton2DAM.Checked == true) // si está seleccionado 2ºDAM
            {
                foreach (Control control in groupBoxModulos2.Controls)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if (!checkBox.Text.Equals("Todos"))
                        modulosActivos.Add(checkBox.Text, checkBox.Checked);
                }
            }
            else MessageBox.Show("No has seleccionado ningún curso");

            return modulosActivos;
        }

        private bool camposCorrectos()
        {
            // List<TextBox> textBoxes = panel1.Controls.OfType<TextBox>().ToList();
            // foreach (Control control in FormAltaAlumno.ControlCollection) { }
            
            //List<Control> controls = new List<Control>()/*{ .... }*/;
            /*foreach (var ctrl in controls.OfType<TextBox>().Where(x => string.IsNullOrEmpty(x.Text)))
            {

                errorProviderNombre.SetError(ctrl, "El campo es obligatorio");

            }*/

            bool camposCorrectos = true;
            if (textBoxNombre.Text.Equals(""))
            {
                errorProviderNombre.SetError(textBoxNombre, "Debes poner un nombre");
                camposCorrectos = false;
            }
            else errorProviderNombre.Clear();

            if (textBoxApellidos.Text.Equals(""))
            {
                errorProviderApellidos.SetError(textBoxApellidos, "Debes poner un apellido");
                camposCorrectos = false;
            }
            else errorProviderApellidos.Clear();
            return camposCorrectos;
        }

        private string seleccionarGrupo()
        {
            if (radioButtonA.Checked == true) return radioButtonA.Text;
            else return radioButtonB.Text;
        }

        private String seleccionarCurso() 
        {
            if (radioButton1DAM.Checked == true) return radioButton1DAM.Text;
            else return radioButton2DAM.Text;
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

        private void radioButton1DAM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1DAM.Checked == true)
            {
                groupBoxModulos1.Visible = true;
                groupBoxModulos2.Visible = false;
            }
        }

        private void radioButton2DAM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2DAM.Checked == true)
            {
                groupBoxModulos1.Visible = false;
                groupBoxModulos2.Visible = true;
            }
        }
    }
}
