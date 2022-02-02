using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebaBBDD02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alumnosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumnosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.institutoDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'institutoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.institutoDataSet.alumnos);

        }
    }
}
