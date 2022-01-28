using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ponerCaracter(string caracter) {
            if (labelPantalla.Text == "0")
                labelPantalla.Text = caracter;
            else
                labelPantalla.Text += caracter;
        }

        private void clic(object sender, EventArgs e) {
            Button button   = (Button) sender;
            String txt      = button.Text;
            ponerCaracter(txt);
        }

        private void buttonMas_Click(object sender, EventArgs e)
        {
            clic(sender,e);
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            clic(sender, e);
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            clic(sender, e);
        }

        private void buttonBarra_Click(object sender, EventArgs e)
        {
            clic(sender, e);
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            clic(sender, e);
        }

    }
}
