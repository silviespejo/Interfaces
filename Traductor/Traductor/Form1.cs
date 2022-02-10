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

namespace Traductor
{
    public partial class Form1 : Form
    {
        private Dictionary<String, String> traducciones;
        public Form1()
        {
            InitializeComponent();
            traducciones = new Dictionary<string, string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Formato del fichero traducciones.txt ->
             * patata=potato;
             * mar=sea;
             * delfín=dolphin;
             * madre=mother;
             */
            // Cada vez que se arranque la aplicación cargaremos los datos del txt en un diccionario

            FileStream stream = new FileStream("C:\\Users\\tzvet\\Desktop\\pruebas\\traducciones.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);

            while (!sr.EndOfStream)
            {
                String linea = sr.ReadLine();
                traducciones.Add(linea.Split("=")[0], linea.Split("=")[1]);
            }

            sr.Close();
            stream.Close();
        }

        private void buttonTraducir_Click(object sender, EventArgs e)
        {
            if (!textBoxSinTraducir.Text.Equals(""))
            {
                if (traducciones.ContainsKey(textBoxSinTraducir.Text))
                {
                    foreach (KeyValuePair<String, String> dic in traducciones)
                        if (dic.Key.Equals(textBoxSinTraducir.Text)) textBoxTraducido.Text = dic.Value.TrimEnd(';');
                    textBoxInfo.Text = "";
                }
                else textBoxInfo.Text = "No existe el campo solicitado";
            }
            else textBoxInfo.Text = "Campo vacío";
        }
    }
}
