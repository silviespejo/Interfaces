using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversorCmPulgadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxCm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxPulgadas.Text = Convert.ToInt32(textBoxCm.Text) / 2.54 + "";
                textBoxInfo.Text = "";
            }
            catch
            {
                textBoxInfo.Text = "No se puede convertir";
            }
        }

        private void textBoxPulgadas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxCm.Text = Convert.ToInt32(textBoxPulgadas.Text) * 2.54 + "";
                textBoxInfo.Text = "";
            }
            catch
            {
                textBoxInfo.Text = "No se puede convertir";
            }
        }
    }
}
