using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace examen
{
    public partial class FormComentario : Form
    {
        User user;
        public FormComentario(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            user.Comentario = textBoxComentario.Text;
            textBoxComentario.Text = "";
            this.Close();
        }

        private void FormComentario_Load(object sender, EventArgs e)
        {
            labelNombreUser.Text = user.Nombre;
            textBoxComentario.Text = user.Comentario;
        }
    }
}
