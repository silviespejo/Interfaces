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
            FileStream stream = new FileStream("alumnos.obj", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Alumno alumno = (Alumno)binaryFormatter.Deserialize(stream);

            mostrarInfoAlumno(alumno);

            stream.Close();
        }

        private void mostrarInfoAlumno(Alumno alumno)
        {
            textBoxNombre.Text = alumno.Nombre;
            textBoxApellidos.Text = alumno.Apellidos;
            textBoxDni.Text = alumno.Dni;
            textBoxMail.Text = alumno.Mail;
            textBoxCurso.Text = alumno.Curso.NombreCurso + " " + alumno.Curso.Grupo;
            textBoxModulo1.Text = alumno
        }
    }
}
