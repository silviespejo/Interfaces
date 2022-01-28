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
    public partial class FormGestionDonantes : Form
    {
        public List<Usuario> listaUsuarios = new List<Usuario>();
        public Dictionary<string, int> diccionarioGrupoFactor = crearDiccionario();
        public FormGestionDonantes()
        {
            InitializeComponent();
        }

        private void nuevoDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNuevoDonante FormNuevoDonante = new FormNuevoDonante(this);
            FormNuevoDonante.Show();
        }

        public void agregarUsuario(Usuario usuario)
        {
            listaUsuarios.Add(usuario);
            // cada vez que añadimos un usuario debemos sumar el valor del diccionario
            ++diccionarioGrupoFactor[usuario.Grupo+usuario.Factor];
        }

        private void busuqedaDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusquedaDonante formBusquedaDonante = new FormBusquedaDonante(listaUsuarios);
            formBusquedaDonante.Show();
        }

        private void bajaDonanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBajaDonante formBajaDonante = new FormBajaDonante(this);
            formBajaDonante.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tiposDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposDisponibles tiposDisponibles = new TiposDisponibles(this);
            tiposDisponibles.Show();
        }

        private static Dictionary<string, int> crearDiccionario() {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>
            {
                { "0+", 0 },
                { "A+", 0 },
                { "B+", 0 },
                { "AB+", 0 },
                { "0-", 0 },
                { "A-", 0 },
                { "B-", 0 },
                { "AB-", 0 },
            };
            return myDictionary;
        }

        public void imprimirDiccionario(TextBox textBox) {
            textBox.Text = "0+: "+diccionarioGrupoFactor["0+"]+ "   0-: " + diccionarioGrupoFactor["0-"] +
                "   A+: " + diccionarioGrupoFactor["A+"] + "   A-: " + diccionarioGrupoFactor["A-"] +
                "   B+: " + diccionarioGrupoFactor["B+"] + "   B-: " + diccionarioGrupoFactor["B-"] +
                "   AB+: " + diccionarioGrupoFactor["AB+"] + "   AB-: " + diccionarioGrupoFactor["AB-"];
        }
    }
}
