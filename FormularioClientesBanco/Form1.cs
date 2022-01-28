using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioClientesBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //esta variable tiene que estar fuera y ser vista por el resto de métodos
        CClientes[] woaClientes = new CClientes[1];
        private void button2_Click(object sender, EventArgs e)
        {
            //Button aceptar
            //se puede hacer un control de excepciones con el try catch o con if para errores más específicos
            try
                Boolean errorCuenta, errorSaldo = false;
                Boolean errorTitular = true;
                String wsTitular = textBox1.Text;
                errorTitular = false; errorCuenta = true;
                int wsCuenta = Convert.ToInt32(textBox2.Text);
                errorCuenta = false; errorSaldo = true;
                float wfSaldo = Convert.ToSingle(textBox3.Text);
                errorSaldo = false;

                //creamos una clase cliente con constructor y guardamos los datos en un array de 
                woaClientes[woaClientes.Length - 1] = new CClientes(wsTitular, wsCuenta, wfSaldo);
                Array.Resize(ref woaClientes, woaClientes.Length + 1);
                
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                label5.Visible = false;

            }catch (Exception) {
                label5.Visible = true;
                label5.Text = "Error al introdicir los datos.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Button cancelar
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button mostrar/ocultar
            label4.Text = "";
            for (int i = 0; i < woaClientes.Length - 1; ++i) {
                label4.Text = label4.Text + woaClientes[i].ToString();
            }
            //mostrar u ocultar según convenga
            if (label4.Visible == true)
                label4.Visible = false;
            else
                label4.Visible = true;
        }
    }

    public class CClientes {
        String psTitular;
        int    piCuenta;
        float  pfSaldo;
        
        public CClientes (String isTitular, int iiCuenta, float ifSaldo) {
            psTitular = isTitular;
            piCuenta  = iiCuenta;
            pfSaldo   = ifSaldo;
        }
 
        override
        public String ToString() {
            return "Titular: "+psTitular+" Cuenta: "+piCuenta+" Saldo: "+pfSaldo+"\n";
        }
    }//CClientes
}
