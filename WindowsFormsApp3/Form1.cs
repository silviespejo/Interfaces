using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime f = dateTimePicker1.Value;
            label4.Text = (f.Day+"/"+f.Month+"/"+f.Year);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Fecha Inicio
            String wsMesInicio;
            DateTime woFechaInicio = monthCalendar1.SelectionStart;
            //El if sirve para añadir un cero a los número menores de 10.
            if (woFechaInicio.Month < 10)
                wsMesInicio = "0" + woFechaInicio.Month.ToString();
            else
                wsMesInicio = woFechaInicio.Month.ToString();
            label5.Text = woFechaInicio.Day.ToString() + "/" + wsMesInicio + "/" + woFechaInicio.Year.ToString();

            //Fecha Fin
            String wsMesFinal;
            DateTime woFechaFinal = monthCalendar1.SelectionEnd;
            if (woFechaFinal.Month < 10)
                wsMesFinal = "0" + woFechaInicio.Month.ToString();
            else
                wsMesFinal = woFechaFinal.Month.ToString();
            label10.Text = woFechaFinal.Day.ToString() + "/" + wsMesFinal + "/" + woFechaFinal.Year.ToString();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
