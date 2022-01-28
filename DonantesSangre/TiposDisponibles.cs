using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonantesSangre
{
    public partial class TiposDisponibles : Form
    {
        FormGestionDonantes formGestionDonantes;
        public TiposDisponibles()
        {
            InitializeComponent();
        }

        public TiposDisponibles(FormGestionDonantes formGestionDonantes)
        {
            InitializeComponent();
            this.formGestionDonantes = formGestionDonantes;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            String grupo = asignarGrupo();
            String factor = asignarFactor();

            // con esto comprobamos is hay usuarios en la lista
            if (formGestionDonantes.listaUsuarios.Count != 0)
            {
                // con esto comprobamos si el usuario a seleccionado algo
                if (!(grupo == "") && !(factor == ""))
                {
                    String grupoFactor = grupo + factor;
                    if (formGestionDonantes.diccionarioGrupoFactor[grupoFactor] > 0)
                        textBoxMostrar.Text = grupoFactor + " disponible";
                    else
                        textBoxMostrar.Text = grupoFactor + " no disponible";
                }
                else MessageBox.Show("No has seleccionado ningún tipo.");
            }
            else MessageBox.Show("No existe ningún usuario.");

            clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMostrarTodo_Click(object sender, EventArgs e)
        {
            formGestionDonantes.imprimirDiccionario(textBoxMostrar);
        }

        private String asignarGrupo()
        {
            if (radioButtonA.Checked) return radioButtonA.Text;
            else if (radioButton0.Checked) return radioButton0.Text;
            else if (radioButtonB.Checked) return radioButtonB.Text;
            else if (radioButtonAB.Checked) return radioButtonAB.Text;
            else return "";
        }

        private String asignarFactor()
        {
            if (radioButtonPositivo.Checked) return radioButtonPositivo.Text;
            else if (radioButtonNegativo.Checked) return radioButtonNegativo.Text;
            else return "";
        }

        private void clear()
        {
            radioButton0.Checked = false;
            radioButtonA.Checked = false;
            radioButtonAB.Checked = false;
            radioButtonB.Checked = false;
            radioButtonNegativo.Checked = false;
            radioButtonPositivo.Checked = false;
        }

    }
}
