using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string textLogin  = textBox1.Text;
            //textBox2.PasswordChar = '*';
            string textPasswd = textBox2.Text;

            if (textLogin == "usr1" && textPasswd == "1234"){
                label3.Text = "Hola, " + textLogin + " tu contraseña es " + textPasswd;
                label3.Visible = true;
            }
            else
            {
                label3.Text    = "Usuario y contraseña incorrecta";
                label3.Visible = true;
                label4.Text    = "Máximo 3 intentos, te quedan "+(2-i);
                label4.Visible = true;
                i++;
            }
            if (i >= 3)
                this.Close();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
