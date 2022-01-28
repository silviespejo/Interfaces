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
    public partial class FormMostrar : Form
    {
        public FormMostrar()
        {
            InitializeComponent();
        }

        public FormMostrar(List<Usuario> listaUsuarios)
        {
            InitializeComponent();

            String stringUsuarios = "DNI\tNombre\tDirección\tTeléfono\tNª Asiento\r\n";
            foreach (Usuario usr in listaUsuarios){
                stringUsuarios += usr.ToString()+"\r\n";
            }
            textBox1.Text = stringUsuarios;
        }

    }
}
