using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen02
{
    public partial class FormPrincipal : Form
    {
        Datos datos;

        public FormPrincipal()
        {
            InitializeComponent();
            datos = new Datos();
        }

        private void salirAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                datos.NombreFichero = openFileDialog.FileName; // almacenamos el nombre del fichero seleccionado
                mostrarFichero();

            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                datos.NombreFichero = saveFileDialog.FileName; // alamcenamos su fileName
                FileStream stream = new FileStream(datos.NombreFichero, FileMode.Create); // creamos el fichero
                stream.Close();
                mostrarFichero();
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datos.NombreFichero = ""; // deseleccionamos el fichero antes seleccionado
            mostrarFichero();
        }

        private void mostrarFichero()
        {
            String[] aux = datos.NombreFichero.Split("\\");
            textBoxFichero.Text = aux[aux.Length-1];
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!datos.NombreFichero.Equals(""))
            {
                FormAltaProducto formAltaProducto = new FormAltaProducto(datos);
                formAltaProducto.Show();
            }
            else MessageBox.Show("No tienes ningún fichero seleccionado!", "Atención!");
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!datos.NombreFichero.Equals(""))
            {
                FormConsultaProductos formConsultaProductos = new FormConsultaProductos(datos);
                formConsultaProductos.Show();
            }
            else MessageBox.Show("No tienes ningún fichero seleccionado!", "Atención!");
        }
    }
}
