using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dibujarPanel
{
    public partial class FormDibujarPanel : Form
    {
        // Dibujar sobre un objeto panel
        bool mouseDown;
        System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
        int inicioX, inicioY;

        public FormDibujarPanel()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            inicioX = e.X;
            inicioY = e.Y;

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point p1 = new Point(inicioX, inicioY);
                Point p2 = new Point(e.X, e.Y);
                // aniade una nueva linea desde p1 a p2
                path.AddLine(p1, p2);
                inicioX = e.X;
                inicioY = e.Y;
                // manda redibujar el panel y ejecuta panel1
                panel1.Invalidate();
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            path.StartFigure();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // dibuja el camino
            if (radioButtonBlack.Checked) e.Graphics.DrawPath(Pens.Black, path);
        }

        private void FormDibujarPanel_Load(object sender, EventArgs e)
        {
            mouseDown = false;
            // iniciar el camino
            path.StartFigure();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // borrar panel
            path.Reset();
            panel1.Invalidate();
        }
    }
}
