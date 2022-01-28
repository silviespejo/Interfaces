using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Todos los archivos(*.*) | *.*|";// +
			    //“Archivos texto(*.txt)| *.txt |” +
			    //“Archivos gráficos | *.gif,*.jpg”;
            textBox1.Text = openFileDialog1.FileName;
        }
    }
}
