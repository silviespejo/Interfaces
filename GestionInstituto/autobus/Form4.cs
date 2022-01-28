using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autobus
{
    public partial class FormComprarBillete : Form
    {
        FormAutobus formAutobus;
        public FormComprarBillete()
        {
            InitializeComponent();
        }

        public FormComprarBillete(FormAutobus formAutobus)
        {
            InitializeComponent();
            this.formAutobus = formAutobus;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            String dni = textBoxDni.Text;
            int numAsiento;
            //este if se hace para que no salte una excepción, numAsiento debe tener siempre un valor, 0 por defecto
            if (textBoxAsiento.Text != "")
                numAsiento = int.Parse(textBoxAsiento.Text);
            else
                numAsiento = 0;

            formAutobus.comprarBillete(dni, numAsiento);

            textBoxAsiento.Clear();textBoxDni.Clear();
        }
    }
}
