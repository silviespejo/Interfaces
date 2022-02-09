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

namespace EditorTexto02
{
    public partial class FormEditorTexto : Form
    {
        Datos datos;
        public FormEditorTexto()
        {
            InitializeComponent();
            datos = new Datos();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!textBoxPrincipal.Text.Equals(""))
            {
                DialogResult result = MessageBox.Show("Deseas guardar antes?", "Atención!", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    guardar();
                    textBoxPrincipal.Text = "";
                    datos.NombreFicheroActual = "";
                }
                else if(result == DialogResult.No)
                {
                    textBoxPrincipal.Text = "";
                    datos.NombreFicheroActual = "";
                }
            }


        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                datos.NombreFicheroActual = openFileDialog.FileName;
                FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(stream);
                textBoxPrincipal.Text = sr.ReadToEnd();

                sr.Close();
                stream.Close();
            }
        }

        private void guardar()
        {
            if (datos.NombreFicheroActual.Equals(""))
                guardarComo();
            else
            {
                FileStream stream = new FileStream(datos.NombreFicheroActual, FileMode.Open, FileAccess.Write);
                StreamWriter sw = new StreamWriter(stream);
                sw.WriteLine(textBoxPrincipal.Text);
                sw.Close();
                stream.Close();
            }
        }

        private void guardarComo()
        {
            // creamos el saveFileDialog para darle un nombre al archivo y saber donde guardarlo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Como";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "All files  |*.*" + "|" +
                                    "Text files |*.txt";


            if (saveFileDialog.ShowDialog() == DialogResult.OK) // solo continuaremos si se pulsa ok
            {
                datos.NombreFicheroActual = saveFileDialog.FileName; // guardamos el fichero con el que estemos tratando
                FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(stream);
                sw.WriteLine(textBoxPrincipal.Text);
                sw.Close();
                stream.Close();
            }
        }

    }
}
