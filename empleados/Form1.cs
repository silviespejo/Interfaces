using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empleados
{
    public partial class Form1 : Form
    {
        empleados[] woEmpleados = new empleados[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button aceptar
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string dni = textBox3.Text;
            string email = textBox4.Text;
            //convertimos todo a minúsculas para evitar errores
            string puesto = textBox5.Text.ToLower();
            DateTime fechaNacimiento = dateTimePicker1.Value;
            DateTime fechaIncorporacion = dateTimePicker2.Value;

            if (puesto.Equals("operario") || puesto.Equals("jefe") || puesto.Equals("mantenimiento")){
                aniadirEmpleado(nombre, apellido, dni, email, puesto, fechaIncorporacion, fechaNacimiento);
                label10.Visible = false;
                limpiar();
            }
            else{
                puesto = textBox5.Text;
                label10.Text = "Error al introducir puesto";
                label10.Visible = true;
                textBox5.Clear();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button cancelar
            limpiar();
        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }

        private void aniadirEmpleado(String nombre, String apellido, String dni, String email, String puesto,
            DateTime fechaIncorporacion, DateTime fechaNacimiento)
        {
            woEmpleados[woEmpleados.Length - 1] = new empleados(nombre, apellido, dni, email, puesto,
                                                                    fechaIncorporacion, fechaNacimiento);
            Array.Resize(ref woEmpleados, woEmpleados.Length + 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //button todos
            label9.Text = "";
            label9.Visible = true;
            for (int i = 0; i < woEmpleados.Length - 1; ++i)
            {
                label9.Text = label9.Text + woEmpleados[i].ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //button mantenimiento
            mostrar("mantenimiento");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button jefe
            mostrar("jefe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button operario
            mostrar("operario");
        }

        private void mostrar(String puesto) {
            label9.Text = "";
            label9.Visible = true;
            for (int i = 0; i < woEmpleados.Length - 1; ++i)
            {
                if (woEmpleados[i].getPuesto().Equals(puesto))
                    label9.Text = label9.Text + woEmpleados[i].ToString();
            }
        }

        class empleados
        {
            string nombre, apellido, dni, email, puesto;
            DateTime fechaNacimiento, fechaIncorporacion;

            public empleados(string inombre, string iapellido, string idni, string iemail, string ipuesto,
                                DateTime ifechaNacimiento, DateTime ifechaIncorporacion)
            {
                this.nombre = inombre;
                apellido = iapellido;
                dni = idni;
                email = iemail;
                puesto = ipuesto;
                fechaNacimiento = ifechaNacimiento;
                fechaIncorporacion = ifechaIncorporacion;
            }

            public String getPuesto()
            {
                return puesto;
            }

            override
            public String ToString()
            {
                return nombre + ", " + apellido + ", " + dni + ", " + email + ", " + puesto + ", " + fechaNacimiento + ", " + fechaIncorporacion + "\n";
            }

        }//empleados

        
    }
}
