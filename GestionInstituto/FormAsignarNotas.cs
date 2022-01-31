using System;
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
    public partial class FormAsignarNotas : Form
    {
        private Alumno alumno = null;
        public FormAsignarNotas()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (File.Exists("alumnos.obj"))
            {
                FileStream stream = new FileStream("alumnos.obj", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                while (stream.Position != stream.Length)
                {
                    alumno = (Alumno)binaryFormatter.Deserialize(stream);
                    if (alumno.Dni.Equals(textBoxBuscar.Text))
                    {
                        mostrarInfoAlumno(alumno);
                    }
                }

                stream.Close();
            }
            else MessageBox.Show("Fichero alumnos.obj no existe.");
        }

        private void mostrarInfoAlumno(Alumno alumno)
        {
            List<TextBox> listaTextBoxModulos = new List<TextBox>();
            List<Label> listaLabelModulos = new List<Label>();
            foreach (Control control in panelTextBoxModulos.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Visible = false;
                    listaTextBoxModulos.Add(textBox);
                }
                else
                {
                    Label label = (Label)control;
                    label.Visible = false;
                    listaLabelModulos.Add(label);
                }
            }

            labelModulos.Visible = true;
            int i = 0;
            foreach (KeyValuePair<String, InfoModulo> modulos in alumno.Curso.Modulos)
            {
                if (modulos.Value.Activo == true)
                {
                    listaLabelModulos[i].Visible = true;
                    listaLabelModulos[i].Text = modulos.Key;
                    listaTextBoxModulos[i].Visible = true;
                    listaTextBoxModulos[i].Text = modulos.Value.NotaFinal.ToString();
                    ++i;
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (alumno != null)
            {

                List<TextBox> listaTextBoxModulos = new List<TextBox>();
                List<Label> listaLabelModulos = new List<Label>();
                foreach (Control control in panelTextBoxModulos.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        listaTextBoxModulos.Add(textBox);
                    }
                    else
                    {
                        Label label = (Label)control;
                        listaLabelModulos.Add(label);
                    }
                }

                FileStream stream = new FileStream("alumnos.obj", FileMode.Open, FileAccess.Read);
                FileStream streamCopia = new FileStream("alumnosCopia.obj", FileMode.Append, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                while (stream.Position != stream.Length) // leemos alumnos.obj
                {
                    alumno = (Alumno)binaryFormatter.Deserialize(stream);
                    if (alumno.Dni.Equals(textBoxBuscar.Text))
                    {
                        int i = 0;
                        foreach (KeyValuePair<String, InfoModulo> modulos in alumno.Curso.Modulos)
                        {
                            alumno.Curso.Modulos[listaLabelModulos[i].Text].NotaFinal = Convert.ToInt32(listaTextBoxModulos[i].Text);
                            ++i;
                        }
                    }
                    binaryFormatter.Serialize(streamCopia, alumno);
                }

                stream.Close();
                streamCopia.Close();
                File.Replace("alumnosCopia.obj", "alumnos.obj", "alumnosBackup.obj");
            }
            else MessageBox.Show("No has seleccionado ningún alumno.");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
