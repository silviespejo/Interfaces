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
    public partial class FormConsultaTodos : Form
    {
        public FormConsultaTodos()
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
                    Alumno alumno = (Alumno)binaryFormatter.Deserialize(stream);
                    if (alumno.Dni.Equals(textBoxBuscar.Text))
                        mostrarInfoAlumno(alumno);
                }

                stream.Close();
            }
            else MessageBox.Show("Fichero alumnos.obj no existe.");
        }

        private void mostrarInfoAlumno(Alumno alumno)
        {
            textBoxNombre.Text = alumno.Nombre;
            textBoxApellidos.Text = alumno.Apellidos;
            textBoxDni.Text = alumno.Dni;
            textBoxMail.Text = alumno.Mail;
            textBoxCurso.Text = alumno.Curso.NombreCurso + " " + alumno.Curso.Grupo;

            List<TextBox> listaTextBoxModulos = new List<TextBox>();
            foreach (Control control in panelTextBoxModulos.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Visible = false;
                    listaTextBoxModulos.Add(textBox);
                }
            }

            // haremos un foreach del diccionario "modulos" que contiene toda la info sobre los módulos de cada alumno,
            // iremos comprobando si cada uno de lo módulos esta activo
            
            labelModulos.Visible = true;
            int i = 0;
            foreach (KeyValuePair<String, InfoModulo> modulos in alumno.Curso.Modulos)
            {
                if (modulos.Value.Activo == true)
                {
                    listaTextBoxModulos[i].Visible = true;
                    listaTextBoxModulos[i].Text = modulos.Key+" = "+modulos.Value.NotaFinal.ToString();
                    ++i;
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
