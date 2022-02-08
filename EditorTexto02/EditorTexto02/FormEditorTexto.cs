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
            // creamos el saveFileDialog para darle un nombre al archivo y saber donde guardarlo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Como";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "All files  |*.*" + "|" +
                                    "Text files |*.txt";
            

            if (saveFileDialog.ShowDialog() == DialogResult.OK) // solo continuaremos si se pulsa ok
            {
                FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);
                stream.Close();
            }
        }
    }
}
