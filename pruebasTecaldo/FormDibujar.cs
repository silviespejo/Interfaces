using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pruebasTecaldo
{
    public partial class FormDibujar : Form
    // proyecto que nos permite dibujar sobre el formulario
    {
        private bool pintar;
        private int anteriorX, anteriorY;

        public FormDibujar()
        {
            InitializeComponent();
        }

        private void FormDibujar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void FormDibujar_MouseUp(object sender, MouseEventArgs e)
        {
            pintar = false;
        }

        private void FormDibujar_MouseDown(object sender, MouseEventArgs e)
        {
            pintar = true;
            anteriorX = e.X;
            anteriorY = e.Y;
        }

        private void FormDibujar_MouseMove(object sender, MouseEventArgs e)
        {
    
        }
    }
}
